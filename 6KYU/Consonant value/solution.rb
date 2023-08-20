def solve(s)
    current = 0
    largest = 0
    
    s.each_byte do |c|
      puts(c)
      if c == 97 || c == 101 || c == 105 || c == 111 || c == 117
        if current > largest
          largest = current
        end
        current = 0
      else
        current += (c - 96)
      end
    end
    return current > largest ? current : largest
end