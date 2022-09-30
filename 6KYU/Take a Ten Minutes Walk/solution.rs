use std::collections::HashMap;

fn is_valid_walk(walk: &[char]) -> bool {
    let mut dirs = HashMap::from([
       ('w', 0), ('e', 0), ('n', 0), ('s', 0)]);
    
    for c in walk {
        if dirs.contains_key(c) {
            dirs.insert(*c, 1 + dirs[&c]);
        }
    }
    
    return dirs[&'w'] == dirs[&'e'] && dirs[&'n'] == dirs[&'s'] && walk.len() == 10;
}
