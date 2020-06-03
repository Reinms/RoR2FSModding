namespace R2L.Reflection

open System

open R2L.Reflection.Internal

module public Operator =
    let inline (?) (this: 'TSource) (name: String) : 'TResult =
        Helpers.GetCachedLookup this name



    let thing = 47
    let thing2: String = thing?ToString()

    //let (?) () : Unit =
    //    ()

    //let (?<-) () : Unit =
    //    ()

    //let thing = 56
    //let thing2 = thing?stuff