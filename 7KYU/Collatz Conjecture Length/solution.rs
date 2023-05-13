fn collatz(mut n: u64) -> u64 {
    let mut c: u64 = 1;
    
    while n != 1 {
        if n % 2 == 0 {
            n /= 2;
        } else {
            n = n * 3 + 1;
        }
        c += 1;
    }
    
    return c;
}
