let getSum a b =
  let s = min a b
  let e = max a b
  
  [s..e] |> List.sum