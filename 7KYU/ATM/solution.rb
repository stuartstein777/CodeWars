def solve(n)
  res = 0
  while n > 0
    if n >= 500
      x = n / 500
      res += x
      n -= (x * 500)
    elsif n >= 200
      x = n / 200
      res += x
      n -= (x * 200)
    elsif n >= 100
      x = n / 100
      res += x
      n -= (x * 100)
    elsif n >= 50
      x = n / 50
      res += x
      n -= (x * 50)
    elsif n >= 20
      x = n / 20
      res += x
      n -= (x * 20)
    elsif n >= 10
      x = n / 10
      res += x
      n -= (x * 10)
    else
      return -1
    end
  end
  res
end
