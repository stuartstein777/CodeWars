def collatz(n):
    res = []
    while n != 1:
        res.append(n)
        if n % 2 == 0:
            n = n // 2
        else:
            n = n*3 + 1
            
    res.append(1)
    return '->'.join(map(str, res))
