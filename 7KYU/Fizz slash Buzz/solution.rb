def fizzbuzz(n)
  multipleOfThree = 0
  multipleOfFive = 0
  multipleOfThreeAndFive = 0
  
  for x in 1..n-1
    if x % 3 == 0 and x % 5 != 0
       multipleOfThree += 1
    end
    if x % 5 == 0 and x % 3 != 0
       multipleOfFive +=1
    end
    if x % 3 == 0 and x % 5 == 0
       multipleOfThreeAndFive += 1
    end
  end
  
  return [multipleOfThree, multipleOfFive, multipleOfThreeAndFive]
end