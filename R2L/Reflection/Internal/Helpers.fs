namespace R2L.Reflection.Internal

open System
open Rein.FSharp
open System.Reflection

module internal Helpers =
    let private flags1 = BindingFlags.Public ||| BindingFlags.NonPublic
    let private staticFlags = flags1 ||| BindingFlags.Static
    let private instanceFlags = flags1 ||| BindingFlags.Instance
    let private instanceFlatFlags = instanceFlags ||| BindingFlags.FlattenHierarchy

    let private FilterToGenericParameters (t: Type) : Boolean =
        if t.IsGenericParameter then
            true
        else
            printfn "Non generic generic parameter found???"
            false



    let private SolveGenerics (method: MethodInfo) (returnType: Type) (suppliedArguments: Type[]) : MethodInfo =
        let genArgs = 
            method.GetGenericArguments()
            |> Array.where FilterToGenericParameters
        let retArgs = Array.append <| [| returnType; |] <| suppliedArguments
        let methodRetArgs = Array.append <| [| method.ReturnParameter; |] <| method.GetParameters()

        let Mapper (ind: Int32) (parameter: ParameterInfo ) : (Int32*ParameterInfo*Int32) =
            let Search (t: Type) : Boolean =
                t == parameter.ParameterType

            let index =
                match Array.tryFindIndex Search genArgs with
                | Some i -> i
                | None -> -1
            (ind, parameter, index)

        let Proj ((_,_,index): Int32*ParameterInfo*Int32) : Int32 =
            index

        let MapGenerics ((origInd,_,_): Int32*ParameterInfo*Int32) : Type =
            retArgs.[origInd]

        let genParams =
            methodRetArgs
            |> Array.mapi Mapper
            |> Array.sortBy Proj
            |> Array.distinctBy Proj
            |> Array.map MapGenerics

        method.MakeGenericMethod( genParams )




    let internal ResolveStaticMethodOverload (targetType: Type) (name: String) (returnType: Type) (suppliedArguments: Type[]) : MethodInfo =
        let method = targetType.GetMethod( name, staticFlags, null, suppliedArguments, null )

        match method with
        | null -> raise <| MissingMethodException(targetType.FullName, name )
        | m when m.IsGenericMethod -> SolveGenerics <| m <| returnType <| suppliedArguments
        | _ -> method


    let internal ResolveInstanceMethodOverload (targetType: Type) (name: String) (returnType: Type) (suppliedArguments: Type[]) : MethodInfo =
        let method = 
            match targetType.GetMethod( name, instanceFlags, null, suppliedArguments, null ) with
            | null -> targetType.GetMethod( name, instanceFlatFlags, null, suppliedArguments, null )
            | x -> x

        match method with
        | null -> raise <| MissingMethodException(targetType.FullName, name )
        | m when m.IsGenericMethod -> SolveGenerics <| m <| returnType <| suppliedArguments
        | _ -> method



