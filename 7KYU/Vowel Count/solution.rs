fn get_count(string: &str) -> usize {
    let mut vowels_count: usize = 0;
    for c in string.chars() { 
        if "aeiou".contains(c) {
            vowels_count=vowels_count + 1;
        }
    }
  
    vowels_count
}