def add_length(str)
  str.split(" ").map { |s| s + " " + s.length.to_s}
end