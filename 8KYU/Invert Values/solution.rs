fn invert(values: &[i32]) -> Vec<i32> {
    return values.iter().map(|c| -c).collect::<Vec<i32>>();
}