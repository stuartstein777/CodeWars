fn basic_op(op: char, a: i32, b: i32) -> i32 {
    return match op {
            '+' => a + b,
            '-' => a - b,
            '/' => a / b,
            '*' => a * b,
            _ => panic!("argh, invalid op")
        }
}