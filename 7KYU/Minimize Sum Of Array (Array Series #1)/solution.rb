def min_sum(arr)
    asc = arr.sort_by{|a| a}
    dsc = arr.sort_by{|a| -a}
    i = 0
    res = 0
    while i < arr.length() do
      res+= asc[i] * dsc[i]
      i=i+1
    end 
    return res/2
  end