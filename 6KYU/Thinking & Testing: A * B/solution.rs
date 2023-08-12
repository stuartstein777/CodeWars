fn sum_digits(n: u64) -> u64 {
    let mut sum = 0;
    let mut n = n;
    
    while n != 0 {
        let d = n % 10;
        sum += d;
        n /= 10;
    }
    
    return sum;
}

fn test_it(a: u64, b: u64) -> u64 {
    return sum_digits(a) * sum_digits(b);
}
