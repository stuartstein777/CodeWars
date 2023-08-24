#preloaded variable: "$dict"

def make_backronym(string)
  string.upcase.chars.map {|s| $dict[s]}.join(" ")
end