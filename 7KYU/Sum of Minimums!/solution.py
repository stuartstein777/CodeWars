def sum_of_minimums(numbers):
    result = 0
    for n in numbers:
        smallest = n[0]
        for m in n:
            if m < smallest:
                smallest = m
        result += smallest
    return result