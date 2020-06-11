namespace R2L.Reflection.Internal

open System
open System.Reflection
open MonoMod.Utils.Cil
open MonoMod.Utils
open Mono.Cecil.Cil
open Rein.FSharp
open Microsoft.FSharp.Reflection

type private OC = Mono.Cecil.Cil.OpCodes

module internal Generator =
    type private MarkerType = struct end
    // A trick to get a type for this Module. typeof<Module> is not allowed so this is required.
    let internal moduleType = typeof<MarkerType>.DeclaringType



    let private tupleFieldFlags = BindingFlags.NonPublic ||| BindingFlags.Instance

    let private ExactMatch (returnType: Type) (args: Type[]) (method: MethodInfo) : Boolean =
        let methodParams = method.GetParameters()

        let Mapper (index: Int32) (parameter: ParameterInfo) : Char[] =
            let suppliedText =
                if index >= args.Length then
                    "NOARG"
                else
                    args.[index].FullName
            let tempText = sprintf "Arg%i:\nGenerated: %s \nTarget: %s \n" index suppliedText parameter.ParameterType.FullName
            tempText.ToCharArray()
        
        try
            let text =
                method.GetParameters()
                |> Array.mapi Mapper
                |> Array.append <| [| (sprintf <| "Return:\nGenerated: %s \nTarget: %s" <| returnType.FullName <| method.ReturnParameter.ParameterType.FullName).ToCharArray(); |]
                |> Array.concat
            Console.WriteLine( String( text ) )
        with
        | _ -> printfn "Error logging method parameters"

        if methodParams.Length != args.Length then
            printfn "Cannot jmp because argument lengths are different"
            false
        else if method.IsGenericMethod then
            printfn "Cannot jmp to a generic method?"
            false
        else
            true


    let rec private EmitLoadNthFromTuple (il: ILProcessor) (index: Int32) (tupleType: Type) : Unit =
        if index <= 7 then
            let itemField = tupleType.GetField( String.Format( "m_Item{0}", index ), tupleFieldFlags )

            il.Emit( OC.Ldfld, itemField )
        else
            let restField = tupleType.GetField( "m_Rest", tupleFieldFlags )

            il.Emit( OC.Ldfld, restField )

            EmitLoadNthFromTuple <| il <| index - 7 <| restField.FieldType
        


    let private EmitLoadArgument (il: ILProcessor) (isStatic: Boolean) (isSingleArgument: Boolean) (tupleType: Type) ((argIndex,suppliedType,argument): Int32 * Type * ParameterInfo ) : Unit =
        if isSingleArgument then
            if isStatic then
                il.Emit OC.Ldarg_0
            else
                il.Emit OC.Ldarg_1
        else if argIndex < 0 then
            raise <| NotImplementedException( "Default arguments not yet implemented" )
        else
            if isStatic then
                il.Emit OC.Ldarg_0
            else
                il.Emit OC.Ldarg_1
        
            if suppliedType == argument.ParameterType then
                EmitLoadNthFromTuple <| il <| argIndex + 1 <| tupleType
            else
                raise <| NotImplementedException( "Boxing and conversions for arguments are not yet implemented" )


    let DirectCast<'TCastTo> (target: Obj) : 'TCastTo =
        target :?> 'TCastTo

    let internal directCastMethod = 
        moduleType.GetMethod( "DirectCast", BindingFlags.NonPublic ||| BindingFlags.Static )

    let internal CastToType (target: Obj) (castTo: Type) : Obj =
        directCastMethod.MakeGenericMethod( castTo ).Invoke( null, [| target; |] )
 

    let internal GenerateFunction<'TDomain, 'TRange, 'TObject, 'TSignature> ((target,name,isStatic): Type*String*Boolean ) : ( 'TObject -> 'TSignature ) =
        let args = 
            if FSharpType.IsTuple( typeof<'TDomain> ) then
                FSharpType.GetTupleElements typeof<'TDomain>
            else if typeof<'TDomain> == null || typeof<'TDomain> == typeof<Unit> then
                Array.Empty<Type>()
            else
                [| typeof<'TDomain>; |]

        let method =
            if isStatic then
                Helpers.ResolveStaticMethodOverload <| target <| name <| typeof<'TRange> <| args
            else
                Helpers.ResolveInstanceMethodOverload <| target <| name <| typeof<'TRange> <| args

        let hasReturn = typeof<'TRange> != null && typeof<'TRange> != typeof<Unit>

        let dmdReturn =
            if hasReturn then
                typeof<'TRange>
            else
                null

        let dmdArgs = 
            if isStatic then
                args
            else
                Array.append [| typeof<'TObject>; |] args

        let dmd = DynamicMethodDefinition( String.Format( "<<ReflHelp<<{0}<<{1}>>>>", target.AssemblyQualifiedName, name ), dmdReturn, dmdArgs )
        let il = dmd.GetILProcessor()

        if ExactMatch <| dmdReturn <| dmdArgs <| method then
            il.Emit( OC.Jmp, method )
        else
            if not isStatic then
                il.Emit OC.Ldarg_0

            let Mapper (index: Int32) (argument: ParameterInfo) : (Int32*Type*ParameterInfo) =
                if index >= args.Length then
                    (-1,null,argument)
                else
                    (index,args.[index],argument)
                
            let ArgEmitter = EmitLoadArgument <| il <| isStatic <| (args.Length == 1) <| typeof<'TDomain> 

            method.GetParameters()
            |> Array.mapi Mapper
            |> Array.iter ArgEmitter

            il.Emit( OC.Call, method )

            il.Emit OC.Ret

        let DebugInstructions (instr: Instruction) : Char[] =
            Array.append <| instr.ToString().ToCharArray() <| [| '\n' |]

        let debugText = 
            il.Body.Instructions
            |> Seq.collect DebugInstructions
            |> Seq.toArray
        
        printfn "\nILInstructions:\n%s" <| String( debugText )

        let generatedMethodInfo = dmd.Generate()

        let generatedMethod = generatedMethodInfo :> MethodBase

        if isStatic then
            if hasReturn then
                let (delType,sigType) = DelegateCreator.GetFuncDelegateAndSig args typeof<'TRange>
                //let delType = typeof<TestDelegate<'TDomain,'TRange>>
                //let fsFuncType = typeof<('TDomain -> 'TRange)>

                let func = generatedMethod.CreateDelegate( delType ) :> Obj

                let temp = Activator.CreateInstance( sigType, [| func; |] ) :?> 'TSignature

                let Result (_: 'TObject) : 'TSignature =
                    temp

                Result
            else
                let (delType,sigType) = DelegateCreator.GetActionDelegateAndSig args



                //let delType = typeof<TestDelegate<'TDomain,Unit>>
                //let fsFuncType = typeof<('TDomain -> Unit)>

                let func = generatedMethod.CreateDelegate( delType ) :> Obj

                let temp = Activator.CreateInstance( sigType, [| func; |] ) :?> 'TSignature

                let Result (_: 'TObject) : 'TSignature =
                    temp

                Result
        else
            if hasReturn then 
                let (delType,sigType) = DelegateCreator.GetInstanceFuncDelegateAndSig typeof<'TObject> args typeof<'TRange>

                //let delType = typeof<InstanceTestDelegate<'TObject,'TDomain,'TRange>>
                //let fsFuncType = typeof<('TObject -> ('TDomain) -> 'TRange)>

                let func = generatedMethod.CreateDelegate( delType ) :> Obj

                let temp = Activator.CreateInstance( sigType, [| func; |] )

                let convertedTemp = temp :?> ( 'TObject -> 'TSignature )

                convertedTemp
            else
                let (delType,sigType) = DelegateCreator.GetInstanceActionDelegateAndSig typeof<'TObject> args

                //let delType = typeof<InstanceTestDelegate<'TObject,'TDomain,Unit>>
                //let fsFuncType = typeof<('TObject -> ('TDomain) -> Unit)>

                let func = generatedMethod.CreateDelegate( delType ) :> Obj

                let temp = Activator.CreateInstance( sigType, [| func; |] )

                let convertedTemp = temp :?> ( 'TObject -> 'TSignature )

                convertedTemp

    let internal GenerateGetAccessor<'TObject, 'TSignature>( target: Type, name: String, isStatic: Boolean ) : ( 'TObject -> 'TSignature ) =
        raise <| NotImplementedException( "Get accessors not yet implemented" )

    let internal GenerateSetAccessor<'TObject, 'TValue>( target: Type, name: String, isStatic: Boolean ) : ( 'TObject -> 'TValue -> Unit ) =
        raise <| NotImplementedException( "Set accessors not yet implemented" )
    