proc solution*(n: int): int =
  var total: int = 0

  for i in 1 .. (n-1):
      if (i mod 3) == 0 or (i mod 5) == 0:
        total = total + i
  return total
