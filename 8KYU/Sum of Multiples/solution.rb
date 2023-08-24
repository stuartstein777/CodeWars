def sum_mul(n, m)
  if n <= 0 or m <= 0 or m == n or m < n
    return "INVALID"
  end
  result = 0
  
  for i in 1..m-1
    if i % n == 0
      result += i
    end
  end
  
  result
end