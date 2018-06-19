namespace BehaviorBeforeData
open System

module UnitsOfMeasure =
    type CheckingAccount = | CheckingAccount
    [<Measure>] type money
    [<Measure>] type meter
    [<Measure>] type sec
    type Deposit = decimal<money>

    let openCheckingAccount (deposit: Deposit) = 
        if deposit >= 500m<money>
            then Some CheckingAccount
            else None

    openCheckingAccount 987m<money> |> Console.WriteLine

    let someMeters = 12.0<meter>
    let someSecs = 2.34<sec>

    let squareMeters = someMeters * someMeters
    let multipleMeters = someMeters * 11.5
    //let addedFeet =  someFeet + 11.5
    let speed = someMeters / someSecs
    // let feetAndSecs = someFeet + someSecs
    let sth = someMeters * speed
    let justMeters = speed * someSecs
    let acceleration = speed / someSecs

    let justNumber = 456.321
    let unitOfMeasuerNumber = justNumber * 1.0<meter>

    let doubleIt (fl: float<_>) =
        fl + fl

    doubleIt someMeters |> Console.WriteLine
    doubleIt someSecs |> Console.WriteLine
