def tidy_number(n)
  digits = n.to_s.chars.map {|c| c.to_i}
  digits == digits.sort
end