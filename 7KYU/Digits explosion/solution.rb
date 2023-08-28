def explode(s)
  digits = s.split("").map {|i| i.to_i}
  rep = digits.map {|i| i.to_s * i}
  rep.join("")  
end