namespace R2L.Reflection

open System

open R2L.Reflection.Internal

open Rein.FSharp

[<AutoOpen>]
module public Operator =

    // The reflective/dynamic Get operator (also used for calls)
    let inline public (?) (this: 'TObject) (name: String) : ( 'TSignature ) =
        // Temporary 
        printfn "Object: %s \nSignature: %s" typeof<'TObject>.FullName typeof<'TSignature>.FullName
        SignatureCache<'TObject,'TSignature>.GetCached( this, name )


    // The reflective/dynamic Set operator (may be used for hooks in the future)
    let inline public (?<-) (this: 'TObject) (name: String) (value: 'TSignature ) : Unit =
        printfn "Object: %s \nSignature: %s" typeof<'TObject>.FullName typeof<'TSignature>.FullName
        SignatureCache<'TObject,'TSignature>.SetCached( this, name, value )

    let thing = 47
    // Wrote out intended use syntax.
    // This will give compiler errors immediately to let me know if something I do has changed the signature

    // Calling a member named ToString that takes no arguments and returns String
    let thing1: String = thing?ToString()

    // Calling a member named ToString that takes arguments and returns String
    let thing2: String = thing?ToString( 42, "hello", new obj() )

    // Reading a field/property named AValue that is of type String
    let thing3: String = thing?AValue

    // Calling a member that returns void and takes no arguments
    do thing?ToString()

    // Calling a member that returns void and takes arguments
    do thing?ToString( "I like cheese" )

    // Setting a field/property named AValue that is of type int
    do thing?AValue <- 5

    
    // Need to test exotic signatures involving refs, ins, and outs to ensure inference can handle them
