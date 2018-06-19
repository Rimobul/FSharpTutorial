namespace DataTypes

module Records = 

    // 2 records
    // also can be value objects on stack if we use the struct attribute
    // [<Struct>]
    type PersonRecord =
        {
            FirstName: string
            LastName: string
            Age: int
        }

    // There are also Classes, which look similar, but their use
    // in F# should be limited (they are better for interoperability with C#,
    // but less useful in F# - e.g. pattern matching).
    // Classes can use inheritance, can be nullable and have more powerful 
    // encapsulation (e.g. private constructor).
    [<AllowNullLiteral>]
    type PersonClass (firstName: string, lastName: string, age: int) = 
        member this.FirstName = 
            firstName

        member this.LastName = 
            lastName

        member this.Age = 
            age

    let lubenko = 
        {
            FirstName = "Lubomir"
            LastName = "Sokolovsky"
            Age = 27
        }

    let func1 person =
        ( person.FirstName, person.Age )

