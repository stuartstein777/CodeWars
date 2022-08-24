def zeros(n): 
    res = 0
    i = 5
    while n / i >= 1:
        res += n // i
        i *= 5
    return res