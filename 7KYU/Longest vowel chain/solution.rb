def isVowel(c)
  c == 'a' or c == 'e' or c == 'i' or c == 'o' || c == 'u'  
end

def solve(s)
 
  max = 0
  cur = 0
  
  for a in s.chars do
      if isVowel(a)
        cur+= 1
      else
        if cur > max
          max = cur
        end
        cur = 0
      end
   end
  
   if max > cur
     return max
   end
  
   return cur
end