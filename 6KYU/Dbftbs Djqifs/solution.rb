def encrypt_char(a, key)
    key = key % 26
    if key < 0
      key = 26+key
    end
    
    if a.ord >= 97 and a.ord <= 122 
        return (((a.ord - 97 + key) % 26) + 97).chr
    elsif a.ord >= 65 and a.ord <= 90
        return (((a.ord - 65 + key) % 26) + 65).chr
    else
        return a
    end
  end
  
  def encryptor(key, message)
    message.chars
           .map {|x| encrypt_char(x, key)}
           .join("")
  end