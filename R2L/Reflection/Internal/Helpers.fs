namespace rec R2L.Reflection.Internal

open System
open System.Reflection
open System.Collections.Generic

open MonoMod.Utils

open Mono.Cecil.Cil

open Microsoft.FSharp.Reflection

open Rein.FSharp


type private OC = Mono.Cecil.Cil.OpCodes

module internal Helpers =
    let private cacheType: Type = typedefof<GenericCache<_,_>>

    let internal GetCachedLookup<'TType,'TSignature> (target:'TType) : (String->'TSignature) =
        if typeof<'TType> = typeof<Type> then

            raise( NotImplementedException() )

        else if typeof<'TType> = typeof<obj> then

            let actualType: Type = target.GetType()
            raise( NotImplementedException() )

        else
            let func (s:String) : 'TSignature =
                GenericCache<'TType,'TSignature>.GetInstance( s, target )
            func



    let firstPassFlags = BindingFlags.Public ||| BindingFlags.NonPublic
    let secondPassFlags = BindingFlags.FlattenHierarchy


    let GetFuncArgs (t: Type) : Type[] =
        if t = typeof<Unit> then
            [| |]
        else if FSharpType.IsTuple t then
            FSharpType.GetTupleElements t
        else
            [|t|]


    let private BuildDmd (name: String) (returnType: Type) (argTypes: Type[] ) : DynamicMethodDefinition =
        DynamicMethodDefinition( name, returnType, argTypes )


    let inline private (|IsConstructor|_|) (method:MethodInfo) : Option<Unit> = if method.IsConstructor then Some() else None
    let inline private (|IsFinal|_|) (method:MethodInfo) : Option<Unit> = if method.IsFinal then Some() else None
    let inline private (|IsNotVirtual|_|) (method: MethodInfo ) : Option<Unit> = if not method.IsVirtual then Some() else None


    let internal GenerateAccessDelegate<'TType,'TSignature> (t:Type) (name:String) : Unit =
        let signature = typeof<'TSignature>
        let isStatic = typeof<'TType> = typeof<Unit>
        let DmdBuilder = BuildDmd <| "Reflection<<<" + t.AssemblyQualifiedName + ":::" + name

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
                    | (a,r) when r = typeof<Unit> -> (GetFuncArgs a,null)
                    | (a,r) -> (GetFuncArgs a,r)
            
                let targetMethod = 
                    match t.GetMethod( name, searchFlags, null, args, null ) with
                    | null -> t.GetMethod( name, secondSearchFlags, null, args, null )
                    | v -> v

                if targetMethod = null then
                    invalidOp <| sprintf "Could not find method: %s in type: %s" name t.FullName

                let dmd = DmdBuilder ret args
                let il = dmd.GetILProcessor()

                if isStatic then
                    il.Emit OC.Ldarg_0
                    if t.IsValueType then
                        il.Emit OC.Unbox_Any

                let GetParamType (paramInfo: ParameterInfo) : Type =
                    paramInfo.ParameterType

                let EmitArg (ind: Int32) (inputType: Type) : Unit =
                    let isByRef = inputType.IsByRef
                    let t =
                        if isByRef then
                            inputType.GetElementType()
                        else
                            inputType
                    let isValueType = t.IsValueType

                    il.Emit OC.Ldarg_1
                    il.Emit (OC.Ldc_I4, ind)
                    
                    if isByRef && not isValueType then
                        il.Emit (OC.Ldelema, typeof<obj> )
                    else
                        il.Emit OC.Ldelem_Ref
                        if isValueType then
                            if not isByRef then
                                il.Emit (OC.Unbox_Any, t)
                            else
                                il.Emit (OC.Unbox, t)

                targetMethod.GetParameters()
                |> Array.map GetParamType
                |> Array.iteri EmitArg

                match targetMethod with
                | IsConstructor -> il.Emit (OC.Newobj, targetMethod :> MethodBase :?> ConstructorInfo)
                | IsFinal | IsNotVirtual -> il.Emit (OC.Call, targetMethod)
                | _ -> il.Emit (OC.Callvirt, targetMethod )

                il.Emit OC.Ret

                dmd
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

                let dmd = DmdBuilder signature arg
                let il = dmd.GetILProcessor()


                raise <| NotImplementedException( "Properties and fields not currently implemented" )

                dmd

        ()
