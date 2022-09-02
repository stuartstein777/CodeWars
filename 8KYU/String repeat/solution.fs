open System.Linq
let repeatStr n s = Enumerable.Repeat(s, n) |> System.String.Concat