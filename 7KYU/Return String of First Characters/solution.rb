def make_string(s)
  s.split(" ").map {|c| c[0]}.join("")
end
