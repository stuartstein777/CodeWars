def collatz n
    c = 1
    
    while n != 1 do
      c = c + 1
      if n % 2 == 0
        n /= 2
      else
        n = n * 3 + 1
      end
    end
    c
end