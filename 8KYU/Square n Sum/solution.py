from functools import reduce

def square_sum(numbers):
    sum = 0;
    for num in numbers:
        sum = sum + (num*num)
    return sum