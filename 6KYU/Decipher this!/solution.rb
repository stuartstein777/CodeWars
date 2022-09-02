def is_number(c)
    ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"].include? c
  end
  
  def decipher_word(str)
    print str
    @chars = str.split("")
    @ascii = @chars.take_while{|i| is_number(i)}
    @first_char = (Integer(@ascii.join "")).chr
    @rest_chars = @chars.drop(@ascii.count)
    @rest_chars[0], @rest_chars[@rest_chars.count-1] = @rest_chars[@rest_chars.count-1], @rest_chars[0]
    String(@first_char) + @rest_chars.join('')
  end
  
  def decipher_this(string)
    string.gsub(/\s+/m, ' ').strip.split(" ").map{|w| decipher_word(w)}.join(' ')
  end
  