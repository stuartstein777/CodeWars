# $letters is preloaded

def nato(word)
  return word.upcase.split("").map { |w| $letters[w] }.join(" ")
end