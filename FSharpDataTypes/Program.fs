namespace DataTypes

module Tuples = 
    open System

    let tuple1 = (5, 10)
    let tuple2 = (4.4, "Some random words")

    let tupleFunc (x, y) = 
        (x + y, x * y)

    tuple1 |> tupleFunc |> string |> Console.WriteLine

    let x, y = tuple1

    let tuple3 = (5, 10)
    tuple1 = tuple3 |> Console.WriteLine

    tuple1 < (5, 11) |> Console.WriteLine

    let tuple4 = struct (4, 4)