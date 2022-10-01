fn minimum(arr: &[i32]) -> i32 {
    return *arr.iter().min().unwrap();
}

fn maximum(arr: &[i32]) -> i32 {
    return *arr.iter().max().unwrap();    
}