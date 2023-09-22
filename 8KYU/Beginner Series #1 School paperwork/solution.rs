fn paperwork(n: i16, m: i16) -> u32 {
    if n < 0 || m < 0 {
        return 0;
    }
    return (m*n) as u32;
}