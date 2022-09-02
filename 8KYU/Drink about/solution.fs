let peopleWithAgeDrink old =
    match old with
        | t when t < 14 -> "drink toddy"
        | t when t < 18 -> "drink coke"
        | t when t < 21 -> "drink beer"
        | _ -> "drink whisky" 