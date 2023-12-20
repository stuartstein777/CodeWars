def beeramid(bonus, price)
  level = 0
  totalcost = 0
  
  while totalcost <= bonus do
    level+=1
    totalcost += level * level * price
  end
  
  level == 0 ? level : level -1
end