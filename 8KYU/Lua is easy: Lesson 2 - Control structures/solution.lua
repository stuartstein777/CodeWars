kata = {}
function kata.solve(n) 
   i = 1
   a = 1
   b = 1
 
   while(i < n) do
       t = a   
       a = a + b
       b = t
       i = i + 1
       print (a, b)
   end
  
  
  return (a * 2) - 1
  
end
return kata
