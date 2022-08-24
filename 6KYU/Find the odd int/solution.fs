let inline findOdd numbers = 
    numbers |> List.reduce(fun a i -> a ^^^ i)