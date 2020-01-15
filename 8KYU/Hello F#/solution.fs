let hello name = match name with
    | None -> "Hello World"
    | Some n -> "Hello, " + n