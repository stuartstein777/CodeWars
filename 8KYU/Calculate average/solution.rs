fn find_average(slice: &[f64]) -> f64 {
    if(slice.len() == 0){
        return 0.0;
    }
    let mut sum: f64 = 0.0;
    
    for i in slice {
        sum = sum + i;
    }
    return sum / (slice.len() as f64);
}