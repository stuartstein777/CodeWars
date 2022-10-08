fn sequence_sum(start: u32, end: u32, step: u32) -> u32 {
    let mut res: u32 = 0;
    let mut i:u32 = start;
    
    while i <= end {
        res = res + i;
        i = i + step;
    }
    
    return res;
}
