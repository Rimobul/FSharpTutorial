namespace DataTypes

module Options = 

    // 4 options
    // there can and may not be a value, or an error
    let safeDivide (x, y) =
        if y = 0.0
            then None
            else Some (x / y)
            