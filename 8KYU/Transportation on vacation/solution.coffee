rentalCarCost = (d) ->
  if(d >= 7)
    (d * 40) - 50
  else if (d >= 3)
    (d * 40) - 20
  else
    d * 40;