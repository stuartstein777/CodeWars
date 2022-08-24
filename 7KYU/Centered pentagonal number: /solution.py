def pentagonal(n):
    print(n)
    if n <= 0:
        return -1
    sol = 1 + ((5 * (n-1) * n) // 2)
    print(sol)
    return sol