fn grow(nums: Vec<i32>) -> i32 {
    return nums.iter().fold(1i32, |a, &b| a * b);
}