fn zeros(n: u64) -> u64 {
    let mut result = 0;
    let mut done = false;
    let mut i = 5;
    while !done {
        result = result + (n / i);
        i *= 5; 
        if n / i < 1 {
            done = true;
        }
    }
    return result;
}