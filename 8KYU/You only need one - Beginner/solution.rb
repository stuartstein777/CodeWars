def check(arr,element)
  
    for i in 0..arr.length() do
      if arr[i] == element
        return true
      end
    end
    return false
end