fn square_sum(vec: Vec<i32>) -> i32 {
    return vec.iter().map(|x| x * x).sum();
}