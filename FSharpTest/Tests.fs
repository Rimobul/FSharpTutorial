module Tests

open Xunit
open Code

[<Fact>]
let ``GCD of 18 and 42 is 6 Xunit`` () =
    let result = gcd 18 42

    Assert.Equal(result, 6)
