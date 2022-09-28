fn first_non_consecutive(arr: &Vec<i32>) -> Option<i32> {
    for i in 0..arr.len() -1 {
        if arr[i+1] - arr[i] > 1 {
            return Some(arr[i+1]);
        }
      }
      return None;
}