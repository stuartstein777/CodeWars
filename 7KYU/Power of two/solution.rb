def power_of_two?(x)
    x == 0 ? false : (x & (x-1)) == 0
end