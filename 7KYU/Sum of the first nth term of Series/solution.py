def series_sum(n):
    total = 0
    d = 1
    while n != 0:
        total += 1/d
        n-=1
        d+= 3
    return format(total, '.2f')