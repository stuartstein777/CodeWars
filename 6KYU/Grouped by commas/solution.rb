def solution(n)
  s = n.to_s
  len = s.length
  
  puts len
  if len <= 3
    return n.to_s
  elsif len % 3 == 0
    return s.chars.each_slice(3).map { |x| x.join("") }.join(",")
  elsif (len - 1) % 3 == 0
    return s[0] + "," + s.chars[1..-1].each_slice(3).map { |x| x.join("") }.reverse.join(",")
  else
    return s[0] + s[1] + "," + s.chars[2..-1].each_slice(3).map { |x| x.join("") }.reverse.join(",")
  end
end