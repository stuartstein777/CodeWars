def even_last(numbers):
    if not numbers:
        return 0
    return sum(numbers[0::2]) * numbers[-1]
    