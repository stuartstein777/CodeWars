oddOrEven = (array) ->
  sum =  array.reduce (( acc , i ) -> acc + i ) , 0
  if sum % 2 == 0
    "even"
  else
    "odd"