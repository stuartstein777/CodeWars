fn parse(code: &str) -> Vec<i32> {
    let mut vec = Vec::new();
    let mut v:i32 = 0;
    for (_, c) in code.chars().enumerate() {
        if c == 'i' {
            v = v + 1;
        } else if c == 'd' {
            v = v - 1;
        } else if c == 's' {
            v = v * v;
        } else if c == 'o' {
            vec.push(v);
        }
    }
    
    return vec;
}