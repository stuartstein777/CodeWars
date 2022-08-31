def consecutive(arr)
    if arr == []
      0  
    else
      r = arr.minmax
      (r[0]...(r[1]+1)).size() - arr.length()
    end
end