use std::collections::HashMap;

fn rotate(c: &char) -> String {
    let rotations = HashMap::from([
    ( 'a', "n" ), ( 'b', "o" ), ( 'c', "p" ), ( 'd', "q" ), ( 'e', "r" ), ( 'f', "s" ), ( 'g', "t" ),
    ( 'h', "u" ), ( 'i', "v" ), ( 'j', "w" ), ( 'k', "x" ), ( 'l', "y" ), ( 'm', "z" ), ( 'n', "a" ),
    ( 'o', "b" ), ( 'p', "c" ), ( 'q', "d" ), ( 'r', "e" ), ( 's', "f" ), ( 't', "g" ), ( 'u', "h" ),
    ( 'v', "i" ), ( 'w', "j" ), ( 'x', "k" ), ( 'y', "l" ), ( 'z', "m" ),
    ( 'A', "N" ), ( 'B', "O" ), ( 'C', "P" ), ( 'D', "Q" ), ( 'E', "R" ), ( 'F', "S" ), ( 'G', "T" ),
    ( 'H', "U" ), ( 'I', "V" ), ( 'J', "W" ), ( 'K', "X" ), ( 'L', "Y" ), ( 'M', "Z" ), ( 'N', "A" ),
    ( 'O', "B" ), ( 'P', "C" ), ( 'Q', "D" ), ( 'R', "E" ), ( 'S', "F" ), ( 'T', "G" ), ( 'U', "H" ),
    ( 'V', "I" ), ( 'W', "J" ), ( 'X', "K" ), ( 'Y', "L" ), ( 'Z', "M" )]);
    
    if rotations.contains_key(c) {
        return rotations[c].to_string();
    }
    return c.to_string();
}
fn rot13(message: &str) -> String {
    if message == "" {
        return "".to_string();
    }
    return message.chars()
                  .enumerate()
                  .into_iter()
                  .map(|(_, c)| rotate(&c))
                  .reduce(|acc, i| acc + &i)
                  .unwrap();
}