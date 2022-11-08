fn is_prime(x: i64) -> bool {
    if x < 2 {
        return false;
    }
    
    let upper = f64::sqrt(x as f64) as i64+1;
    for i in 2..upper {
        if x % i == 0 {
            return false;
        }
    }
    
    return true;
}