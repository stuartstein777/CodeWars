def find_longest(arr)
  
  longest = 0
  res = 0
  
  arr.each do |n|
    if n.to_s.length > longest.to_s.length
      longest = n
    end
  end
  longest
end