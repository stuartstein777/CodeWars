def solve s
    s.scan(/[A-Z]/).length > s.length / 2 ? s.upcase :  s.downcase
end