fn find_smallest_int(arr: &[i32]) -> i32 {
    return *arr.iter().min().unwrap();
}