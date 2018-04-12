module FsTest

open Code
open FsUnit
open Xunit

[<Fact>]
let ``gcd of 15 and 45 is 15`` () =
    let result = gcd 15 45

    result |> should equal 15