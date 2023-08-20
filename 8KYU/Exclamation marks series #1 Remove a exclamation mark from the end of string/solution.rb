def remove(s)
    s.end_with?("!") ? s[0..s.length()-2] : s
end