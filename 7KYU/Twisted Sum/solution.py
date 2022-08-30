def sum_digits(n):
    r = 0
    while n:
        r, n = r + n % 10, n // 10
    return r

def compute_sum(n):
    res = 0
    for i in range(0, n+1):
        res += sum_digits(i)
    return res
        