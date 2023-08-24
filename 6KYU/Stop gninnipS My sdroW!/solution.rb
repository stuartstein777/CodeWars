def spin_words(string)
  string.split(" ").map {|x| x.length >= 5 ? x.reverse : x}.join(" ")
end