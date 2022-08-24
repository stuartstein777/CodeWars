past(H, M, S, Result) :- 
  Result is ((S * 1000) + (M * 60000) + (H * 3600000)).