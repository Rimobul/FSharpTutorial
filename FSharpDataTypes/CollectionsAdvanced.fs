namespace DataTypes

module CollectionsAdvanced = 
    let testList = List.init 20 (fun n -> n * 5)
    printfn "%i" (List.length testList)
    testList |> List.isEmpty |> printfn "%b"
    testList |> List.sum |> printfn "%i"
    testList |> List.min |> printfn "%i"
    // at least one satisfies condition
    testList |> List.exists (fun n -> n = 5) |> printfn "%b"
    // all satisfy condition
    testList |> List.forall (fun n -> n = 55) |> printfn "%b"
    // finds the first one which satisfies the condition
    testList |> List.tryFind (fun n -> n % 3 = 0) |> ignore
    // finds all which satisfy the condition
    testList |> List.filter (fun n -> n % 3 = 0) |> ignore

