namespace R2L.Reflection

open System

open R2L.Reflection.Internal

open Rein.FSharp

[<AutoOpen>]
module public Operator =
    let inline public (?) (this: 'TObject) (name: String) : ( 'TResult ) =
        printfn "Object: %s \nResult: %s" typeof<'TObject>.FullName typeof<'TResult>.FullName
        SignatureCache<'TObject,'TResult>.GetCached( this, name )

    //let public (?) (this: 'TObject) (name: String) : ( 'TResult ) =
    //    printfn "Object: %s Range: %s" typeof<'TObject>.FullName typeof<'TResult>.FullName
    //    Unchecked.defaultof<('TResult)>


    let thing = 47
    let thing2: String = thing?ToString( 42, "hello", new obj() )

    let otherThing = 23
    let thing3: String = otherThing?Value


    //let (?) () : Unit =
    //    ()

    //let (?<-) () : Unit =
    //    ()

    //let thing = 56
    //let thing2 = thing?stuff