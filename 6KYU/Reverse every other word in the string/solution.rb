def reverse_alternate(string)

  revd = string.split(" ").map.with_index do |word, idx|
    idx % 2 != 0 ? word.reverse : word
  end
  
  revd.join(" ")
end