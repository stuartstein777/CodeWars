def sum_cubes(n)
  sum = 0
  
  1.upto(n) do |i|
    sum += i * i * i
  end
  
  sum
end