namespace Tests.R2L.Reflection
open NUnit.Framework
open System.Diagnostics
open System.Reflection
open System.Collections.Generic



[<SingleThreaded>]
module _TESTS =
    open System
    open R2L
    open R2L.Reflection
    open R2L.Reflection.Operator
    open Rein.FSharp

    [<Repeat(50)>]
    [<Test( ExpectedResult = "TestOutput" )>]
    let ``String = String?ToString()`` () : String =
        let myStr = "TestOutput"
        myStr?ToString()

    [<Repeat(50)>]
    [<Test( ExpectedResult = "TestOutput" )>]
    let ``String = typeof<String>?Format( String, String )`` () : String =
        typeof<String>?Format( "Test{0}", "Output" )

    [<Repeat(50)>]
    [<Test>]
    let ``Unit = typeof<Console>?WriteLine( String )`` () : Unit =
        typeof<Console>?WriteLine( "TestOutput" )

    [<Repeat(50)>]
    [<Test( ExpectedResult = true )>]
    let ``Unit = List<Int32>?Add( Int32 )`` () : Boolean =
        let myList = List<Int32>()
        myList?Add( 15 )
        myList.Count == 1 && myList.[0] == 15

    [<Repeat(50)>]
    [<Test( ExpectedResult = true )>]
    let ``Unit = List<Object>?Add( Int32 )`` () : Boolean =
        Assert.Fail()
        let myList = List<Object>()
        myList?Add( 15 )
        myList.Count == 1 && myList.[0] :?>Int32 == 15
    
    [<Repeat(50)>]
    [<Test( ExpectedResult = true)>]
    let ``Int32[] = typeof<Array>?Empty()`` () : Boolean =
        let myArray: Int32[] = typeof<Array>?Empty()
        myArray != null && myArray.Length = 0

    