def is_upper_letter(c)
    c.count("A-Z") > 0  
 end
 
 def capitals(word)
   puts word
   res = []
   word.chars.each_with_index do |item, index|
       if is_upper_letter item
         res << index
       end
   end
   res
end
 
 