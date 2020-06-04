namespace R2L.Reflection.Internal

open System
open System.Collections.Generic
open Microsoft.FSharp.Reflection
open Rein.FSharp
open System.Dynamic


[<AbstractClass>]
[<Sealed>]
type public SignatureCache<'TObject,'TResultSignature>() =
    class
        static let isFunction = FSharpType.IsFunction( typeof<'TResultSignature> )
        static let domainType, rangeType =
            if isFunction then
                FSharpType.GetFunctionElements( typeof<'TResultSignature> )
            else 
                null, null


        static let isStatic = typeof<'TObject> = typeof<Type>
        static let isUnknownType = typeof<'TObject> = typeof<Obj>
        static let isDynamic = typeof<'TObject>.GetInterface( typeof<IDynamicMetaObjectProvider>.Name ) != null
        
        static let instanceDict = Dictionary<String,('TObject -> 'TResultSignature)>()
        static let staticDict = Dictionary<Type,Dictionary<String,'TResultSignature>>()
        static let unknownTypeDict = Dictionary<Type,Dictionary<String,(Obj -> 'TResultSignature)>>()

        //type GetResultsDelegate = delegate of 'TObject


        //Need to have a delegate with a default implementation
        //Static constructor time the default implementation is used to compile a faster implementation
        //Faster implementation is used for all actual calls
        //This allows for multiple accesses to the same signature to share that performance boost for their first time compiles
        //In particular will be important for the static and unknown paths


       
        

        static member public GetCached( target: 'TObject, name: String ) : ( 'TResultSignature ) =
            if isDynamic then

                // Implement redirect to normal dynamic here
                Unchecked.defaultof<( 'TObject -> 'TResultSignature )>(target)

            else if isStatic then
                
                //Static lookup
                let staticType = target :> Obj :?> Type
                let subDict = 
                    match staticDict.TryGetValue staticType with
                    | (success,value) when success -> value
                    | _ ->
                        let newDict = Dictionary<String,'TResultSignature>()
                        staticDict.[staticType] <- newDict
                        newDict

                match subDict.TryGetValue name with
                | (success, value) when success -> value
                | _ ->
                    //Implement static generation call
                    if isFunction then
                        raise( NotSupportedException( "Function reflection is not currently supported" ) )
                    else
                        Unchecked.defaultof<'TResultSignature>

            else if isUnknownType then

                //Unknown lookup
                let unknownType = target.GetType()
                let subDict =
                    match unknownTypeDict.TryGetValue unknownType with
                    | (success, value) when success -> value
                    | _ ->
                        let newDict = Dictionary<String,(Obj -> 'TResultSignature)>()
                        unknownTypeDict.[unknownType] <- newDict
                        newDict

                match subDict.TryGetValue name with
                | (success, value) when success -> value(target)
                | _ ->
                    //Implement unknown generation call
                    if isFunction then
                        raise( NotSupportedException( "Function reflection is not currently supported" ) )
                    else
                        Unchecked.defaultof<( Obj -> 'TResultSignature )>(target)

            else

                //Instance lookup
                match instanceDict.TryGetValue name with
                | (success, value) when success -> value(target)
                | _ ->
                    //Implement instance generation call
                    if isFunction then
                        raise( NotSupportedException( "Function reflection is not currently supported" ) )
                    else
                        Unchecked.defaultof<( 'TObject -> 'TResultSignature )>(target)

    end