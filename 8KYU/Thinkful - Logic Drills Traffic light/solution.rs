fn update_light(current: &str) -> String {
    if current == "red" {
        return "green".to_string();
    } else if current == "yellow" {
        return "red".to_string();
    } else {
        return "yellow".to_string();
    }      
}