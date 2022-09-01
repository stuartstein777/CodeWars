import math
def strong_num(n):
  digits = map(int, str(n))
  total = 0
  for d in digits:
    total = total + math.factorial(d)
  if total == n:
    return "STRONG!!!!"
  return "Not Strong !!"
  
