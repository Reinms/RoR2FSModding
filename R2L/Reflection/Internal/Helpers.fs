namespace rec R2L.Reflection.Internal

open System
open System.Reflection
open System.Collections.Generic

//open MonoMod.Utils

//open Mono.Cecil.Cil

open Microsoft.FSharp.Reflection

open Rein.FSharp


//type private OC = Mono.Cecil.Cil.OpCodes

module internal Helpers =
    let private cacheType: Type = typedefof<GenericCache<_,_>>

    let internal GetCachedLookup<'TType,'TSignature> (target:'TType) : (String->'TSignature) =
        match typeof<'TType> with
        | t when t = typeof<Type> -> (GenericCache<'TSignature>.GetStatic <| (target :> obj :?> Type))
        | t when t = typeof<obj> -> (GenericCache<'TSignature>.GetInstance <| target.GetType() <| target)
        | _ -> (GenericCache<'TType,'TSignature>.GetInstance <| target)


[<AbstractClass>]
[<Sealed>]
type internal GenericCache<'TType, 'TSignature> =
    class
        static member private lookup : Dictionary<String,'TType->'TSignature> = Dictionary<String,'TType->'TSignature>()
        static member private count : Int32 = 0
        static member private onlyItem : 'TType->'TSignature = Unchecked.defaultof<'TType->'TSignature>
        

        static member internal GetInstance (instance:'TType) (name:String) : 'TSignature =
            if GenericCache<'TType, 'TSignature>.count = 1 then
                GenericCache<'TType,'TSignature>.onlyItem instance
            else
                let success, value = GenericCache<'TType,'TSignature>.lookup.TryGetValue name
                if success then
                    value instance
                else
                    let func = Generator.GenerateAccessDelegate<'TType,'TSignature> <| instance.GetType() <| name
                    GenericCache<'TType,'TSignature>.lookup.[name] <- func
                    func( instance )

    end

[<AbstractClass>]
[<Sealed>]
type internal GenericCache<'TSignature> =
    class 
        static member private lookupDict: Dictionary<Type,Dictionary<String,obj->'TSignature>> = Dictionary<Type,Dictionary<String,obj->'TSignature>>()

        static member internal GetStatic (t:Type) (name:String) : 'TSignature =
            Unchecked.defaultof<'TSignature>

        static member internal GetInstance (t:Type) (instance:obj) (name:String) : 'TSignature =
            Unchecked.defaultof<'TSignature>
    end

module internal Generator =
    
    let firstPassFlags = BindingFlags.Public ||| BindingFlags.NonPublic
    let secondPassFlags = BindingFlags.FlattenHierarchy


    let GetFuncArgs (t: Type) : Type[] =
        if t = typeof<Unit> then
            [| |]
        else if FSharpType.IsTuple t then
            FSharpType.GetTupleElements t
        else
            [|t|]


    //let private BuildDmd (name: String) (returnType: Type) (argTypes: Type[] ) : DynamicMethodDefinition =
    //    DynamicMethodDefinition( name, returnType, argTypes )


    let inline private (|IsConstructor|_|) (method:MethodInfo) : Option<Unit> = if method.IsConstructor then Some() else None
    let inline private (|IsFinal|_|) (method:MethodInfo) : Option<Unit> = if method.IsFinal then Some() else None
    let inline private (|IsNotVirtual|_|) (method: MethodInfo ) : Option<Unit> = if not method.IsVirtual then Some() else None


    let internal GenerateAccessDelegate<'TType,'TSignature> (t:Type) (name:String) : ('TType -> 'TSignature) =
        let signature = typeof<'TSignature>
        let isStatic = typeof<'TType> = typeof<Unit>
        //let DmdBuilder = BuildDmd <| "Reflection<<<" + t.AssemblyQualifiedName + ":::" + name

        let searchFlags = 
            firstPassFlags |||
            if isStatic then
                BindingFlags.Static
            else
                BindingFlags.Instance
        let secondSearchFlags = searchFlags ||| secondPassFlags

        let dynamicMethodDef = 
            if FSharpType.IsFunction( signature ) then
                let args, ret = 
                    match FSharpType.GetFunctionElements( signature ) with
                    | (a,r) when r = typeof<Unit> -> (GetFuncArgs a, null)
                    | (a,r) -> (GetFuncArgs a, r)

                let MatchTypeOrObject (provided:Type) (found:Type) =
                    provided = found || provided = typeof<obj>

                let NameFilter (method:MethodInfo) : Boolean =
                    method.Name = name

                let GetParamType (paramInfo: ParameterInfo) : Type =
                    paramInfo.ParameterType

                let GetParamsArray (method: MethodInfo) : (Type[]*MethodInfo) =
                    let parameters =
                        method.GetParameters()
                        |> Array.map GetParamType

                    (parameters,method)


                let ReturnTypesMatch (method: MethodInfo) : Boolean =
                    MatchTypeOrObject ret method.ReturnType

                let ArgCountsMatch ((methodArgs,_): Type[]*MethodInfo) : Boolean =
                    methodArgs.Length >= args.Length

                let ArgMatcher ((ind,argType): Int32*Type) : Boolean =
                    MatchTypeOrObject args.[ind] argType

                let HasNoInvalidArgMatches ((methodArgs,_): Type[]*MethodInfo) : Boolean =
                    methodArgs
                    |> Array.indexed
                    |> Array.forall ArgMatcher

                let ScoreFolder (start: Int32) (types: Type*Type) : Int32 =
                    match types with
                    | (t1, t2) when t1 = t2 -> 2
                    | (t1, _) when t1 = typeof<obj> -> 1
                    | _ -> -1

                let ArgScore ((methodArgs,method): Type[]*MethodInfo) : (Int32*Type[]*MethodInfo) =
                    let initValue = (args.Length - methodArgs.Length) * 2
                    let score = 
                        methodArgs
                        |> Array.allPairs( args )
                        |> Array.fold ScoreFolder initValue
                    (score,methodArgs,method)

                let ReadScore ((score,_,_): Int32*Type[]*MethodInfo) : Int32 =
                    score

                let ScoreNonNegative ((score,_,_): Int32*Type[]*MethodInfo) : Boolean =
                    score >= 0

                let ReadMethod ((_,_,method): Int32*Type[]*MethodInfo) : MethodInfo =
                    method

                let MainFilter (methods:MethodInfo[]) : Option<MethodInfo> =
                    methods
                    |> Array.where NameFilter
                    |> Array.where ReturnTypesMatch
                    |> Array.map GetParamsArray
                    |> Array.where ArgCountsMatch
                    |> Array.where HasNoInvalidArgMatches
                    |> Array.map ArgScore
                    |> Array.sortByDescending ReadScore
                    |> Array.where ScoreNonNegative
                    |> Array.map ReadMethod
                    |> Array.tryHead

                let targetMethod = 
                    match MainFilter <| t.GetMethods( searchFlags ) with
                    | Some method -> method
                    | None -> 
                        match MainFilter <| t.GetMethods( secondSearchFlags ) with
                        | Some method -> method
                        | None -> invalidOp <| sprintf "Could not find method: %s in type: %s" name t.FullName
                
                //let dmd = DmdBuilder ret args
                //let il = dmd.GetILProcessor()

                //if isStatic then
                //    il.Emit OC.Ldarg_0
                //    if t.IsValueType then
                //        il.Emit OC.Unbox_Any



                //let EmitArg (ind: Int32) (inputType: Type) : Unit =
                //    let isByRef = inputType.IsByRef
                //    let t =
                //        if isByRef then
                //            inputType.GetElementType()
                //        else
                //            inputType
                //    let isValueType = t.IsValueType

                //    il.Emit OC.Ldarg_1
                //    il.Emit (OC.Ldc_I4, ind)
                    
                //    if isByRef && not isValueType then
                //        il.Emit (OC.Ldelema, typeof<obj> )
                //    else
                //        il.Emit OC.Ldelem_Ref
                //        if isValueType then
                //            if not isByRef then
                //                il.Emit (OC.Unbox_Any, t)
                //            else
                //                il.Emit (OC.Unbox, t)

                //targetMethod.GetParameters()
                //|> Array.map GetParamType
                //|> Array.iteri EmitArg

                //match targetMethod with
                //| IsConstructor -> il.Emit (OC.Newobj, targetMethod :> MethodBase :?> ConstructorInfo)
                //| IsFinal | IsNotVirtual -> il.Emit (OC.Call, targetMethod)
                //| _ -> il.Emit (OC.Callvirt, targetMethod )

                //il.Emit OC.Ret

                //dmd
                ()
            else
                let arg =
                    if isStatic then
                        [| |]
                    else
                        [| t |]
            
                let targetField =
                    match t.GetField( name, searchFlags ) with
                    | null -> t.GetField( name, secondSearchFlags )
                    | v -> v

                let targetProperty =
                    match t.GetProperty( name, searchFlags ) with
                    | null -> t.GetProperty( name, secondSearchFlags )
                    | v -> v

                if targetField = null && targetProperty = null then
                    invalidOp <| sprintf "Could not find field or property: %s in type: %s" name t.FullName
                else if targetField != null && targetProperty != null then
                    // TODO: Switch this to use bepinex logger
                    printfn "Both field and property named: %s found in type %s, defaulting to field" name t.FullName

                //let dmd = DmdBuilder signature arg
                //let il = dmd.GetILProcessor()


                raise <| NotImplementedException( "Properties and fields not currently implemented" )

                //dmd
                ()

        let Temp (_: 'TType) : 'TSignature =
            Unchecked.defaultof<'TSignature>

        Temp