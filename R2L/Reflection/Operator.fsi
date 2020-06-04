namespace R2L.Reflection
open System

module Operator =
    val inline (?) : this: 'TObject -> name: String -> 'TResult

    val inline (?<-) : this: 'TObject -> name: String -> value: 'TSignature -> Unit