def array_plus_array(arr1, arr2)
    arr1.inject(0, :+) + arr2.inject(0, :+)
end