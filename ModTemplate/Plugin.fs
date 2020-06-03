namespace ModTemplate

open System
open BepInEx
open ReinCore
open System.Reflection
open Rein.FSharp.Mappings

[<BepInPlugin("com.Rein.TestStuff", "FSTESTING", "1.0.0.0")>]
type internal Plugin() =
    inherit BaseUnityPlugin()

    static do
        let execAsm = Assembly.GetExecutingAssembly()
        let resourceName =
            execAsm.GetManifestResourceNames()
            |> Array.find ( fun x -> x.Contains( "ReinCore.dll" ) )

        use stream = execAsm.GetManifestResourceStream( resourceName )
        let bytes: Byte[] = Array.zeroCreate <| int stream.Length  
        stream.Read(bytes, 0, bytes.Length)
        |> ignore
        let asm = Assembly.Load( bytes )
        let mainType = asm.GetType("ReinCore.ReinCore")
        let method = mainType.GetMethod( "Init" )
        let args = Array.create 7 (true :> obj)
        method.Invoke( null, args )
        |> ignore
        
    with
        member _.Awake() =
            base.Logger.LogWarning( "I EXIST!!!!" )
            if ReinCore.loaded then
                base.Logger.LogWarning( "Loaded" )
            else
                base.Logger.LogWarning( "Not Loaded" )

        member _.Start() =
            if ReinCore.loaded then
                base.Logger.LogWarning( "Loaded" )
            else
                base.Logger.LogWarning( "Not Loaded" )