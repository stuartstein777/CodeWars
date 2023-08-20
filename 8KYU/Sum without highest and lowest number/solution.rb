def sum_array(arr)
    if arr == nil or arr == []
      return 0
    end
    
    minmax = arr.minmax
    if minmax[0] == minmax[1]
      return arr.inject(0, :+) - minmax[0]
    else
      return arr.inject(0, :+) - minmax.inject(0,:+)
    end
end