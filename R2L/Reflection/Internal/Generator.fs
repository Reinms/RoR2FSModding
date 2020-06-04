namespace R2L.Reflection.Internal

open System

module internal Generator =
    type private MarkerType = struct end
    // A trick to get a type for this Module. typeof<Module> is not allowed so this is required.
    let internal moduleType = typeof<MarkerType>.DeclaringType

    let internal GenerateFunction<'TDomain, 'TRange, 'TObject, 'TSignature>( target: Type, name: String, isStatic: Boolean ) : ( 'TObject -> 'TSignature ) =
        // Implement
        Unchecked.defaultof<('TObject -> 'TSignature)>

    let internal GenerateGetAccessor<'TObject, 'TSignature>( target: Type, name: String, isStatic: Boolean ) : ( 'TObject -> 'TSignature ) =
        // Implement
        Unchecked.defaultof<('TObject -> 'TSignature)>

    let internal GenerateSetAccessor<'TObject, 'TValue>( target: Type, name: String, isStatic: Boolean ) : ( 'TObject -> 'TValue -> Unit ) =
        // Implement
        Unchecked.defaultof<('TObject -> 'TValue -> Unit)>
    