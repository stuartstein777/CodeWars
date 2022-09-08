module Solution
export sumofmultiples

  function sumofmultiples(number)
     total = 0

     for i in 0:number-1
         if i % 3 == 0 || i % 5 == 0
           total = total + i
         end
     end
     return total
  end

end