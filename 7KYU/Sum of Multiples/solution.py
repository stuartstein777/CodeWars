def sum_mul(n, m):
    print(n)
    print(m)
    if n <= 0 or m <= 0:
        return 'INVALID';
    if m < n or m == n:
        return 0
    result = 0
    for x in range(1, m):
        if x % n == 0:
            result += x
    return result