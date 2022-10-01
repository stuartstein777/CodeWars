fn century(year: u32) -> u32 {
    if year <= 100 {
        return 1;
    }
    
    if year % 100 == 0 {
        return year / 100;
    }
    
    return (year / 100) + 1;
}