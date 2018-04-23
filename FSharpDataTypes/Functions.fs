namespace DataTypes
open System

module Functions = 
    // 6. functions
    // each function must take one argument and return one value
    let func1 x =
        x * x

    func1 12 |> Console.WriteLine
    12 |> func1 |> Console.WriteLine

    // we specify the input argument's type and compiler infers the result
    let func2(x: float) =
        x * x

    12.0 |> func2 |> Console.WriteLine

    // we specify the return type and compiler infers the argument
    let func3 x : float =
        x * x

    // function with no input cannot exist - empty argument is repredented by ()
    // unit is a value which should be ignored
    let emptyFunc () = 
        printfn "This function takes not arguments"

    // how are functions with multiple arguments possible? 
    // they are in fact nested functions
    // so this is a function, which takes one argument, then retuns another function
    // which takes another argument and only then returns an integer result
    let twoArguments x y =
        x * y

    // the previous statement can be demonstrated on partial functions
    let partialFunc = twoArguments 11
    8 |> partialFunc |> printfn "%i"

    // alternatively, we can use a tuple as an argument
    let tupleFunc (x, y) = 
        x * y

    // we can create functions which return functions explicitely
    let explicitFunc () =
        // anonymous functions start with fun
        (fun x -> x * x)    
    
    explicitFunc () 55 |> Console.WriteLine

    let innerFunc f x =
        f x

    innerFunc (fun x -> x * x) 6 |> printfn "%i"
    6 |> innerFunc (fun x -> x * x ) |> printfn "%i"

(*
    Various usages of parentheses
    () - unit type
    (1, 2) - tuple
    (n: int) - explicit type declaration
    (fun x -> x + x) - anonymous function
*)
