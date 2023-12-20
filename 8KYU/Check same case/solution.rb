def letter(l)
    l.match(/[A-Za-z]/)
end

def same_case(a, b)
  if !letter(a) || !letter(b)
    return -1
  elsif (a.downcase == a && b.downcase == b) || (a.upcase == a && b.upcase == b) then
    return 1
  else
    return 0
  end
end