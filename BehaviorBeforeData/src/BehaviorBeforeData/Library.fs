namespace BehaviorBeforeData

module BehaviorBeforeData = 
    type CheckingAccount = | CheckingAccount
    type Application = | Application
    type Identification = | Identification
    type Deposit = decimal

    let openCheckingAccount 
        (application: Application)
        (id: Identification * Identification)
        (deposit: Deposit) =
            if deposit >= 500M
                then Some CheckingAccount
                else None