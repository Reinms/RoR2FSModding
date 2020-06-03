namespace rec Rein.FSharp

[<AutoOpen>]
module CustomOperators =
    let inline ( != ) x y =
        x <> y