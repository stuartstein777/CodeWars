fn best_match(a: &[u8], b: &[u8]) -> usize {
    let mut smallestGoalDiff:u8 = a[0] - b[0];
    
    let mut idx:usize = 0;
    let mut g:u8 = b[0];
    
    for i in 1..a.len() {
        let goalDiff:u8 = a[i] - b[i];
        if goalDiff < smallestGoalDiff {
            smallestGoalDiff = goalDiff;
            idx = i;
            g = b[i];
        } else if goalDiff == smallestGoalDiff && b[i] > g {
            g = b[i];
            idx = i;
        }
    }
    
    return idx;
}
