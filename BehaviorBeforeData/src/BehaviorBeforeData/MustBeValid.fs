namespace BehaviorBeforeData

module MustBeValid = 
    module CheckingAccounts = 
        type CheckingAccount = | CheckingAccount

        type Identification =
            | DriverLicense of string
            | SSNCard of string
            | MilitaryId of string
            | Passport of string

        type TwoIds = | Ids of Identification * Identification
        type DifferentIds = private | PrivateIds of Identification * Identification

        let makeDifferentIds (id1: Identification) (id2: Identification) =
            match (id1, id2) with
            | (DriverLicense _), (DriverLicense _)
                -> None
            | (SSNCard _), (SSNCard _)
                -> None
            | (MilitaryId _), (MilitaryId _)
                -> None
            | (Passport _), (Passport _)
                -> None
            | _
                -> Some (PrivateIds (id1, id2))

        let openCheckingAccount (ids: TwoIds) = 
            let Ids (id1, id2) = ids
            CheckingAccount

        let openCheckingAccount2 (ids: DifferentIds option) = 
            let Ids (id1, id2) = ids
            CheckingAccount

    module Tests = 
        open CheckingAccounts

        let goodIds = Ids((DriverLicense "abc"), (Passport "123"))
        let account1 = openCheckingAccount goodIds

        let badIds = Ids((DriverLicense "abc"), (DriverLicense "def"))
        let account2 = openCheckingAccount badIds

        // This is no longer possible
        // let privateIds = PrivateIds((DriverLicense "abc"), (Passport "123"))

        // this will return Some 
        let privateIds = makeDifferentIds (DriverLicense "abc") (Passport "123")
        // and this will work
        let account3 = openCheckingAccount2 privateIds

        // this will return None
        let noneIds = makeDifferentIds (DriverLicense "abc") (DriverLicense "def")
        // and this will cause a runtime error
        let account4 = openCheckingAccount2 noneIds