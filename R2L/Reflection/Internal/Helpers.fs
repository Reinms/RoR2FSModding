namespace R2L.Reflection.Internal

open System
open Rein.FSharp
open System.Reflection

module internal Helpers =
    let private flags1 = BindingFlags.Public ||| BindingFlags.NonPublic
    let private staticFlags = flags1 ||| BindingFlags.Static
    let private instanceFlags = flags1 ||| BindingFlags.Instance
    let private instanceFlatFlags = instanceFlags ||| BindingFlags.FlattenHierarchy

    let MatchArgType (suppliedType: Type) (argParam: ParameterInfo) : Boolean =
        suppliedType == argParam.ParameterType || suppliedType == typeof<Obj>
        // Will need to do some magic here to check byrefs

    let private FilterName (name: String) (method: MethodInfo)  : Boolean =
        method.Name == name

    let private FilterReturnType (returnType: Type) (method: MethodInfo) : Boolean =
        MatchArgType returnType method.ReturnParameter

    let private CheckEachArgument (supplied: Type[]) ((index,parameter): Int32 * ParameterInfo) : Boolean =
        if index >= (supplied.Length) then
            parameter.HasDefaultValue || parameter.IsOptional
        else
            MatchArgType supplied.[index] parameter

    let private FilterArguments (supplied: Type[]) (method: MethodInfo) : Boolean = 
        let methodArgs = method.GetParameters()

        if methodArgs.Length >= supplied.Length then
            methodArgs
            |> Array.indexed
            |> Array.forall( CheckEachArgument supplied )
        else
            false

    let private ScoreArg (parameters: ParameterInfo[] ) (inScore: Int32) ((index,suppliedType): Int32 * Type) : Int32 =
        if parameters.[index].ParameterType == suppliedType then
            1
        else
            0

    let private CalculateScore (args: Type[]) (method: MethodInfo) : Int32 =
        let parameters = method.GetParameters()
        let initialScore = args.Length - parameters.Length
        let scoreFolder = ScoreArg parameters
        args
        |> Array.indexed
        |> Array.fold scoreFolder initialScore




    let internal ResolveStaticMethodOverload (targetType: Type) (name: String) (returnType: Type) (suppliedArguments: Type[]) : MethodInfo =
        let firstPass =
            targetType.GetMethods( staticFlags )
            |> Array.where( FilterName name )
            |> Array.where( FilterReturnType returnType )
            |> Array.where( FilterArguments suppliedArguments )

        if firstPass.Length <= 0 then
            raise <| MissingMethodException( "Placeholder message" )
        else if firstPass.Length == 1 then
            firstPass
            |> Seq.head
        else
            firstPass
            |> Array.sortByDescending( CalculateScore suppliedArguments )
            |> Array.head


    let internal ResolveInstanceMethodOverload (targetType: Type) (name: String) (returnType: Type) (suppliedArguments: Type[]) : MethodInfo =
        let firstPass =
            let firstCandidates =
                targetType.GetMethods( instanceFlags )
                |> Array.where( FilterName name )
                |> Array.where( FilterReturnType returnType )
                |> Array.where( FilterArguments suppliedArguments )

            if firstCandidates.Length <= 0 then
                targetType.GetMethods( instanceFlatFlags )
                |> Array.where( FilterName name )
                |> Array.where( FilterReturnType returnType )
                |> Array.where( FilterArguments suppliedArguments )
            else
                firstCandidates

        if firstPass.Length <= 0 then
            raise <| MissingMethodException( "Placeholder message" )
        else if firstPass.Length == 1 then
            firstPass
            |> Seq.head
        else
            firstPass
            |> Array.sortByDescending( CalculateScore suppliedArguments )
            |> Array.head



