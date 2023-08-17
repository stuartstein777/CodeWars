fn two_are_positive(a: i32, b: i32, c: i32) -> bool {
    return (a > 0 && b > 0 && c <= 0) ||
           (a > 0 && b <= 0 && c > 0) ||
           (a <= 0 && b > 0 && c > 0);
}