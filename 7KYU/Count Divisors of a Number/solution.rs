fn divisors(n: u32) -> u32 {
    let mut total_divisors: u32 = 0;
    
    for i in 1..n+1 {
        if n % i == 0 {
            total_divisors = total_divisors + 1;
        }
    }
    return total_divisors;
}