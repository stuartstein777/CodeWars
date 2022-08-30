# Sum Numbers
def sum(numbers)
    numbers.any? ? numbers.reduce(:+) : 0
  end