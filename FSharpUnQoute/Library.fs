module FSharpUnQoute

open Code
open Swensen.Unquote
open Xunit

[<Fact>]
let ``GCD of 18 and 42 is 6 UnQuote`` () =
    let result = gcd 18 42

    test <@ result = 6 @>
