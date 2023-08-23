def convert number
  number.chars.each_slice(2).map{|n| n.join.to_i.chr}.join
end