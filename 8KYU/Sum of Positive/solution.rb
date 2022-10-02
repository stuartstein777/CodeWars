def positive_sum(arr)
    arr.reduce(0) do |acc, i| i > 0 ? acc+i : acc end
end
  