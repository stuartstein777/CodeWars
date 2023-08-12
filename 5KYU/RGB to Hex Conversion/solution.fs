let clamp (min : int) (max : int) (n : int) : int =
    if n < min then min
    else if n > max then max
    else n

let rgb r g b =
    let r = clamp 0 255 r
    let g = clamp 0 255 g
    let b = clamp 0 255 b
    
    r.ToString("X2") + g.ToString("X2") + b.ToString("X2")
    
