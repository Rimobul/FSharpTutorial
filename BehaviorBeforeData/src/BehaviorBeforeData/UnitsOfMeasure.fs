namespace BehaviorBeforeData
open System

module UnitsOfMeasure =
    type CheckingAccount = | CheckingAccount
    [<Measure>] type money
    [<Measure>] type ft
    [<Measure>] type sec
    type Deposit = decimal<money>

    let openCheckingAccount (deposit: Deposit) = 
        if deposit >= 500m<money>
            then Some CheckingAccount
            else None

    openCheckingAccount 987m<money> |> Console.WriteLine

    let someFeet = 12.0<ft>
    let someSecs = 2.34<sec>

    let squareFeet = someFeet * someFeet
    let multipleFeet = someFeet * 11.5
    //let addedFeet =  someFeet + 11.5
    let speed = someFeet / someSecs
    // let feetAndSecs = someFeet + someSecs
    let sth = someFeet * speed
    let justFeet = speed * someSecs
    let acceleration = speed / someSecs

    let justNumber = 456.321
    let unitOfMeasuerNumber = justNumber * 1.0<ft>

    let doubleIt (fl: float<_>) =
        fl + fl

    doubleIt someFeet |> Console.WriteLine
    doubleIt someSecs |> Console.WriteLine
