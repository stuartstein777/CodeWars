fn get_grade(s1: u16, s2: u16, s3: u16) -> char {
    let mean = (s1 + s2 + s3) / 3;
    
    if mean >= 90 {
        return 'A';
    } else if mean >= 80 {
        return 'B';
    } else if mean >= 70 {
        return 'C';
    } else if mean >= 60 {
        return 'D';
    } else {
        return 'F';
    }
}