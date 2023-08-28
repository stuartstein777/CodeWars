def last(x)
  x.split(" ").sort_by { |word| word[-1] }
end