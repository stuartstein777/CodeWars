fn max_multiple(divisor: u32, bound: u32) -> u32 {
    return bound - bound % divisor;
}