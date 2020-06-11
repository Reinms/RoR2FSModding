namespace R2L.Reflection.Internal

open System
open System.Collections.Generic
open Microsoft.FSharp.Reflection
open Rein.FSharp
open System.Dynamic
open MonoMod.Utils

type BFlags = System.Reflection.BindingFlags


// Delegate type to store the function generation in. Needed because more generics are extracted from the inputs
type internal FunctionGeneratorDelegate<'TDomain,'TRange,'TObject,'TResultSignature> = delegate of (Type * String * Boolean) -> ('TObject -> 'TResultSignature)

// TObject is the thing that the call was performed on
// TResultSignature represents the context inferred type of the return.
// This is specifically possible because of type inference with generics in F#
[<AbstractClass>]
[<Sealed>]
type public SignatureCache<'TObject,'TResultSignature>() =
    class
        
        // Checks if the inferred result type is a function and grabs the domain and range if it is
        static let isFunction = FSharpType.IsFunction( typeof<'TResultSignature> )
        static let domainType, rangeType =
            if isFunction then
                FSharpType.GetFunctionElements( typeof<'TResultSignature> )
            else 
                null, null

        // if this is called on a type object then access static members
        static let isStatic = typeof<'TObject> = typeof<Type>

        // if this is called on System.Object then assume the actual type is private
        static let isUnknownType = typeof<'TObject> = typeof<Obj>

        // if this is called on something implementing IDynamicMetaObjectProvider, then redirect to the dynamic implementation
        static let isDynamic = typeof<'TObject>.GetInterface( typeof<IDynamicMetaObjectProvider>.Name ) != null
        
        // The caches for the generated functions
        static let instanceDict = Dictionary<String,('TObject -> 'TResultSignature)>()
        static let staticDict = Dictionary<Type,Dictionary<String,(Unit -> 'TResultSignature)>>()
        static let unknownTypeDict = Dictionary<Type,Dictionary<String,('TObject -> 'TResultSignature)>>()

        static let instanceSetDict = Dictionary<String,('TObject -> 'TResultSignature -> Unit)>()
        static let staticSetDict = Dictionary<Type,Dictionary<String,(Unit -> 'TResultSignature -> Unit)>>()
        static let unknownTypeSetDict = Dictionary<Type,Dictionary<String,('TObject -> 'TResultSignature -> Unit)>>()


        static let genMethod =
            if isFunction then
                Generator.moduleType.GetMethod( "GenerateFunction", BFlags.NonPublic ||| BFlags.Static ).GetGenericMethodDefinition().MakeGenericMethod( domainType, rangeType, typeof<'TObject>, typeof<'TResultSignature> )
            else
                null

        // This is needed in order to give more data in generics to the generator
        // That is important because without this data, it is impossible to output the generated delegate properly and quickly
        //static let functionGen: FunctionGeneratorDelegate<_,_,'TObject,'TResultSignature> =
        //    if isFunction then
        //        let delType = typedefof<FunctionGeneratorDelegate<_,_,_,_>>.MakeGenericType( domainType, rangeType, typeof<'TObject>, typeof<'TResultSignature> )
        //        let modType = Generator.moduleType
        //        let targetMethod = modType.GetMethod( "GenerateFunction", BFlags.NonPublic ||| BFlags.Static )
        //        let genMethod = targetMethod.GetGenericMethodDefinition().MakeGenericMethod( domainType, rangeType, typeof<'TObject>, typeof<'TResultSignature> )
        //        //let del = genMethod.Ld
        //        Delegate()
        //        |> Extensions.CastDelegate<FunctionGeneratorDelegate<_,_,'TObject,'TResultSignature>>
        //    else
        //        null


        // Fighting the CLR's delegate creation safety checks is infuriating
        // So instead, just eat the 2 order of magnitude performance hit and use methodinfo.Invoke
        // Only hits on first call, so it doesn't actively defeat the purpose of this entire codebase anyway
        static let GenerateFunction (targetType: Type) (name: String) (isStatic: Boolean) : ('TObject -> 'TResultSignature)  =
            genMethod.Invoke( null, [| targetType; name; isStatic; |] ) :?> ('TObject -> 'TResultSignature)


        static member public GetCached( target: 'TObject, name: String ) : ( 'TResultSignature ) =
            if isDynamic then

                // Implement dynamic get
                Unchecked.defaultof<( 'TObject -> 'TResultSignature )>(target)

            else if isStatic then
                
                // Static
                let staticType = target :> Obj :?> Type

                // Lookup/create the dictionary for this specific type 
                let subDict = 
                    match staticDict.TryGetValue staticType with
                    | (success,value) when success -> value
                    | _ ->
                        let newDict = Dictionary<String,(Unit -> 'TResultSignature)>()
                        staticDict.[staticType] <- newDict
                        newDict
                
                // Check for a cached function and call it if present
                match subDict.TryGetValue name with
                | (success, value) when success -> value()
                | _ ->
                    // Use the generator to create the required function, store it, and call it
                    // Use a different generator for functions and field/property reads
                    if isFunction then
                        let func = GenerateFunction staticType name true
                        let Stored () : 'TResultSignature =
                            func( Unchecked.defaultof<'TObject> )
                        subDict.[name] <- Stored
                        Stored()
                    else
                        let func = Generator.GenerateGetAccessor<'TObject, 'TResultSignature>( staticType, name, true )
                        let Stored () : 'TResultSignature =
                            func( Unchecked.defaultof<'TObject> )
                        subDict.[name] <- Stored
                        Stored()

            else if isUnknownType then

                // Unknown Type
                let unknownType = target.GetType()

                // Lookup/create the dictionary for this type
                let subDict =
                    match unknownTypeDict.TryGetValue unknownType with
                    | (success, value) when success -> value
                    | _ ->
                        let newDict = Dictionary<String,('TObject -> 'TResultSignature)>()
                        unknownTypeDict.[unknownType] <- newDict
                        newDict

                // Check for a cached function and call it if present
                match subDict.TryGetValue name with
                | (success, value) when success -> value(target)
                | _ ->
                    // Use the generator to create the required function, store it, and call it
                    // Use a different generator for functions and field/property reads
                    if isFunction then
                        let func = GenerateFunction unknownType name false
                        subDict.[name] <- func
                        func( target )
                    else
                        let func = Generator.GenerateGetAccessor<'TObject, 'TResultSignature>( unknownType, name, false )
                        subDict.[name] <- func
                        func( target )

            else

                // Instance
                match instanceDict.TryGetValue name with
                | (success, value) when success -> value(target)
                | _ ->
                    // Use the generator to create the required function, store it, and call it
                    // Use a different generator for functions and field/property reads
                    if isFunction then
                        let func = GenerateFunction typeof<'TObject> name false
                        instanceDict.[name] <- func
                        func( target )
                    else
                        
                        let func = Generator.GenerateGetAccessor<'TObject, 'TResultSignature>( typeof<'TObject>, name, false )
                        instanceDict.[name] <- func
                        func( target )



        static member public SetCached( target: 'TObject, name: String, valueToSet: 'TResultSignature ) : Unit =
            if isDynamic then

                // Impmement dynamic set
                ()

            else if isStatic then
                
                // Static
                let staticType = target :> Obj :?> Type

                // Lookup/create the dictionary for this specific type 
                let subDict = 
                    match staticSetDict.TryGetValue staticType with
                    | (success,value) when success -> value
                    | _ ->
                        let newDict = Dictionary<String,(Unit -> 'TResultSignature -> Unit)>()
                        staticSetDict.[staticType] <- newDict
                        newDict
                
                // Check for a cached function and call it if present
                match subDict.TryGetValue name with
                | (success, value) when success -> value () <| valueToSet
                | _ ->
                    // Generate the set accessor
                    if isFunction then
                        
                        raise <| NotImplementedException( "Setting of functions is not currently supported" )
                        // Maybe apply hook here? idk
                
                    else
                        
                        let func = Generator.GenerateSetAccessor<'TObject,'TResultSignature>( staticType, name, true )
                        let Stored (_: Unit) (value: 'TResultSignature) : Unit =
                            func Unchecked.defaultof<'TObject> value
                        subDict.[name] <- Stored
                        Stored () valueToSet

            else if isUnknownType then
                
                // Unknown Type
                let unknownType = target.GetType()

                // Lookup/create the dictionary for this specific type 
                let subDict = 
                    match unknownTypeSetDict.TryGetValue unknownType with
                    | (success,value) when success -> value
                    | _ ->
                        let newDict = Dictionary<String,('TObject -> 'TResultSignature -> Unit)>()
                        unknownTypeSetDict.[unknownType] <- newDict
                        newDict
                
                // Check for a cached function and call it if present
                match subDict.TryGetValue name with
                | (success, value) when success -> value target valueToSet
                | _ ->
                    // Generate the set accessor
                    if isFunction then
                        
                        raise <| NotImplementedException( "Setting of functions is not currently supported" )
                        // Maybe apply hook here? idk
                
                    else
                        
                        let func = Generator.GenerateSetAccessor<'TObject,'TResultSignature>( unknownType, name, false )
                        subDict.[name] <- func
                        func target valueToSet

            else
                
                // Instance
                // Check for a cached function and call it if present
                match instanceSetDict.TryGetValue name with
                | (success, value) when success -> value target valueToSet
                | _ ->
                    // Generate the set accessor
                    if isFunction then
                        raise <| NotImplementedException( "Setting of functions is not currently supported" )
                        // Maybe apply hook here? idk
                    else
                        
                        let func = Generator.GenerateSetAccessor<'TObject, 'TResultSignature>( typeof<'TObject>, name, false )
                        instanceSetDict.[name] <- func
                        func target valueToSet


    end