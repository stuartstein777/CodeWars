let findShort (str : string) = 
    str.Split(' ')
       |> Array.map(fun x -> x.Length)
       |> Array.min