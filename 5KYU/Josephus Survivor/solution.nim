proc josephusSurvivor*(n: int, k: int): int =
  var r = 0
  var i = 1
  while i!=n+1:
    r = (r+k) mod i
    i = i + 1
    
  return r+1