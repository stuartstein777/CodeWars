def isVowel(c)
  c == 'a' or c == 'e' or c == 'i' or c == 'o' || c == 'u'  
end

def swap(st)
  st.chars.map {|c| isVowel(c) ? c.upcase : c}.join("")
end