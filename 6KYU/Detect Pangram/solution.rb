def pangram?(string)
    alphabet = "abcdefghijklmnopqrstuvwxyz"
    string = string.downcase
    for a in alphabet.chars
      if !string.include?(a)
        return false
      end
    end
    
    true
end