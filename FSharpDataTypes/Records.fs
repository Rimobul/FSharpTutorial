namespace DataTypes

module Records = 

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

