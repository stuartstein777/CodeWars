twoArePositive = (a, b, c) ->
  (a > 0 && b > 0 && c <= 0) ||
  (a > 0 && b <= 0 && c > 0) ||
  (a <= 0 && b > 0 && c > 0)