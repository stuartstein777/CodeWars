use regex::Regex;

fn alphanumeric(password: &str) -> bool {
    if(password.len() == 0) {
        return false;
    }
    
    let re = Regex::new(r"[^a-zA-Z0-9]").unwrap();
    return !re.is_match(password)
    
}