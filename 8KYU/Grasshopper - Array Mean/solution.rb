def find_average(nums)
    nums.size == 0 ? 0 : nums.reduce(:+) / nums.size.to_f
end