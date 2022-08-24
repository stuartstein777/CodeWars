fn odd_or_even(numbers: Vec<i32>) -> String {
    if (numbers.iter().fold(0, |sum, i| sum+i) % 2) == 0
    {
        return "even".to_string();
    }
    return "odd".to_string();
}