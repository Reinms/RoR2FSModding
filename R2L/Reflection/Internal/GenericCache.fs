namespace rec R2L.Reflection.Internal

open System
open System.Reflection
open System.Collections.Generic

open MonoMod.Utils
open Microsoft.FSharp.Reflection

[<AbstractClass>]
[<Sealed>]
type internal GenericCache<'TType, 'TSignature> =
    class
        static member private lookup : Dictionary<String,'TType->'TSignature> = Dictionary<String,'TType->'TSignature>()
        static member private count : Int32 = 0
        static member private onlyItem : 'TType->'TSignature = Unchecked.defaultof<'TType->'TSignature>
        

        static member internal GetInstance( name:String, instance:'TType ) : 'TSignature =
            if GenericCache<'TType, 'TSignature>.count = 1 then
                GenericCache<'TType,'TSignature>.onlyItem instance
            else
                let success, value = GenericCache<'TType,'TSignature>.lookup.TryGetValue name
                if success then
                    value instance
                else
                    raise <| NotImplementedException()

    end

[<AbstractClass>]
[<Sealed>]
type internal GenericCache<'TSignature> =
    class 
        static member private lookupDict: Dictionary<Type,Dictionary<String,obj->'TSignature>> = Dictionary<Type,Dictionary<String,obj->'TSignature>>()

        static member internal GetStatic( t:Type, name:String ) : 'TSignature =
            Unchecked.defaultof<'TSignature>

        static member internal GetInstance( t:Type, name:String, instance:obj ) : 'TSignature =
            Unchecked.defaultof<'TSignature>
    end