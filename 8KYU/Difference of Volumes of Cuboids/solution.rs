fn find_difference(a: &[i32; 3], b: &[i32; 3]) -> i32 {
    let a_size:i32 = a.iter().fold(1, |acc, x| acc * x);
    let b_size:i32 = b.iter().fold(1, |acc, x| acc * x);
    
    if(a_size > b_size) {
        return a_size - b_size;
    }
    return b_size - a_size;
}