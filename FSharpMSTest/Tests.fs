namespace FSharpMSTest

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open Code

[<TestClass>]
type TestClass () =

    [<TestMethod>]
    member this.GCDisValid () =
        let result = gcd 14 49

        Assert.AreEqual(7, result)
