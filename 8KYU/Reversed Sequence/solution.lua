local kata = {}

function kata.reverse_seq(n)
  res = {}
  for i = 1, n do
    res[i] = n-i+1
  end
  return res
end

return kata