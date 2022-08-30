def average(array)
    (array.reduce(:+).to_f / array.size).round
end