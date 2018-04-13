namespace DataTypes

module Collections = 
    // Stored in memory cells next to each other
    // Mutable
    let array   =   [|1..10|]
    let ar1 = [|1;2;3|]
    let ar2 = [| for i in 1..3 -> i |]
    let ar3 = Array.init 3 (fun id -> id + 1)
    let ar4 = Array.create 3 0

    array.[2] <- 7
    // Linked list
    let list    =   [1..10]
    // ??? An interface hiding underlying collection
    let seq1    =   seq {1..10}
    // Hashtable
    let set1    =   set {1..10}
    // Indexed hashtable
    let map1    =   Map.empty
                        .Add(1, "One").Add(2, "Two").Add(3, "Three")