let Grow (x : int[]) =
    Array.fold (fun x y -> x * y) 1 x
