fn find_short(s: &str) -> u32 {
    return s.split_whitespace()
            .into_iter()
            .map(|x| x.chars().count() as u32)
            .min()
            .unwrap();
}