def row_sum_odd_numbers(n):
    last = (n * n) + (n - 1)
    start = last - (2 * (n - 1))
    return ((start + last) / 2) * n