namespace BehaviorBeforeData

module SingleValuedUnions =
    type CheckingAccountApplication = 
        {
            FirstName: string
            LastName: string
            HomePhone: string
            Email: string
        }

    type FirstName = | FirstName of string
    type LastName = | LastName of string
    type PhoneNumber = | PhoneNumber of string
    type Email = | Email of string

    type TypedAccountApplication = 
        {
            FirstName: FirstName
            LastName: LastName
            HomePhone: PhoneNumber
            EmailAddress: Email
        }

    let makeCheckingAccountApplication
        firstName lastName homePhone email = 
        {
            FirstName = firstName
            LastName = lastName
            HomePhone = homePhone
            Email = email
        }

    let makeTypedAccountApplication
        firstName lastName homePhone emailAddress = 
        {
            FirstName = firstName
            LastName = lastName
            HomePhone = homePhone
            EmailAddress = emailAddress
        }

    let application = makeCheckingAccountApplication "James" "Bond" "123" "james@bo.nd"

    let firstName = FirstName "James"
    let lastName = LastName "Bond"
    let homePhone = PhoneNumber "123"
    let emailAddress = Email "james@bo.nd"

    let typedApplication = makeTypedAccountApplication firstName lastName homePhone emailAddress

    // pattern matching
    let innerType = match firstName with FirstName s -> s
    // shorted version of pattern matching / casting
    let (FirstName innerType1) = firstName