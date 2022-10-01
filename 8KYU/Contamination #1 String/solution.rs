fn contamination(text: &str, character: &str) -> String {
    if text == "" || character == "" {
        return "".to_string();
    }
    let mut s: String = "".to_string();
    
    for _ in 0..text.chars().count() {
        s = s + character;
    }
    return s;
}
