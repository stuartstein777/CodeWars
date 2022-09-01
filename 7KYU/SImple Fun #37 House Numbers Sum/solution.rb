def house_numbers_sum(input_array)
    input_array.take_while { |i| i != 0 }
               .sum
end