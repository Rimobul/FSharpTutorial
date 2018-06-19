namespace DataTypes

open System
module Collections = 

    // 5 collections - all are generic

    // 5A array
    // Stored in memory cells next to each other
    // Mutable - contents of any cell can be replaced
    // Any member can be accessed in constant time - the fasted reading
    // Cannot change its size - when resizing an array, a new array must be created instead
    let array   =   [|1..10|]
    let ar1 = [|1;2;3|]
    let ar2 = [| for i in 1..3 -> i |]
    let ar3 = Array.init 3 (fun id -> id + 1)
    let ar4 = Array.create 3 0

    // mutation
    array.[2] <- 7

    // 5B list
    // Linked list - each node contains data and pointer to the next node
    // Immutable data in each node
    let list    =   [ 1..10 ]
    let l1 = [ 1; 2; 3 ]
    let l2 = [ for i in 1..3 -> i ]
    let l3 = List.init 3 (fun id -> id + 1)
    // unlike array, an empty list can be created
    let l4 : int list = []

    // immutable
    // l4.[2] <- 7
    
    // the cons operator adds a new element to the head of the old list,
    // essentially creating a pointer to the start of a "new list"
    let l5 = 0 :: l1
    // lists are great for recursion and pattern matching
    let rec printTheList l = 
        match l with
        | []
            -> ()
        | head :: tail
            ->  printfn "%i" head 
                printTheList tail

    l5 |> printTheList                   

    // 5C sequence
    // ??? An interface hiding underlying collection, must implement IEnumerable
    // it can be lazy 
    let seq1    =   seq {1..10}
    seq1 |> Seq.take 1 |> Console.WriteLine
    let seq2 = seq { for i in 1..3 -> i }
    let seq3 = Seq.init 3 (fun id -> id + 1)
    // because the execution is deferred, we can create an infinite sequence
    let seq4 = Seq.initInfinite (fun id -> id + 1)
    seq4 |> Seq.take 1 |> Console.WriteLine
    // or contain other collection
    let seqar1 = seq [|1;2;3|]
    let seqar2 = seq [|1..3|]
    let seql1 = seq [1;2;3]
    let seql2 = seq [1..3]

    // 5D set
    // Hashtable - set behavior in an immutable collection
    // automatically prevents duplicate values
    // types stores in sets must support equality and comparison
    let set1    =   set {1..10}
    let set2 = set [1; 2; 2; 3]
    // Add creates a new set instance and does not change the content of existing set
    let set3 = set2.Add 8
    set2.IsProperSubsetOf set2 |> Console.WriteLine

    // 5E map
    // Indexed hashtable = immutable dictionary
    let map1    =   Map.empty
                        .Add(1, "One")
                        .Add(2, "Two")
                        .Add(3, "Three")

    map1.[2] |> Console.WriteLine