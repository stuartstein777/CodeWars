#removing all odd numbers from an array
def remove_odd_numbers_from_array(a)
    return a.select { |num|  num.even?  } 
end