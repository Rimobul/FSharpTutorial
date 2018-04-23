namespace DataTypes

module Records = 

    // 2 records
    // also can be value objects on stack if we use the struct attribute
    [<Struct>]
    type PersonRecord =
        {
            FirstName: string
            LastName: string
            Age: int
        }

    let lubenko = 
        {
            FirstName = "Lubomir"
            LastName = "Sokolovsky"
            Age = 27
        }

    let func1 person =
        ( person.FirstName, person.Age )

