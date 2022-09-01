def find_all arr,n
    arr.each_index.select{|i| arr[i] == n}
end