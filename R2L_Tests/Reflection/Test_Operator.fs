namespace Tests.R2L.Reflection
open NUnit.Framework




module _TESTS =
    open System
    open R2L
    open R2L.Reflection
    open R2L.Reflection.Operator

    [<SetUp>]
    let Setup () =
        ()

    [<Test>]
    let ``String = String?ToString()`` () : Unit =
        try
            let myStr = ""
            let someValue: String = myStr?ToString()

            Assert.Pass()
        with
            e -> Assert.Fail( e.ToString() )
