def typist(s)
  caps_on = false
  clicks = 0
  
  for c in s.chars
    if c >= 'A' and c <= 'Z' and !caps_on
      caps_on = true
      clicks += 2
    elsif c >= 'a' and c <= 'z' and caps_on
      caps_on = false
      clicks += 2
    else
      clicks += 1
    end
  end
  
  clicks
end