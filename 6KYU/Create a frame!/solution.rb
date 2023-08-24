def padding(text, length, char)
  padding_needed = length - text.length - 2
  Array.new(padding_needed-1, " ").join("")
end

def frame(text, char)
  largest = text.max_by {|x| x.length}.length
  top_bottom = Array.new(largest+4, char).join("")
  
  text = text.map {|x| char + " " + x + padding(x, largest+4, char) + char}
  text.unshift(top_bottom)
  text.push(top_bottom)
  
  return text.join("\n")
end