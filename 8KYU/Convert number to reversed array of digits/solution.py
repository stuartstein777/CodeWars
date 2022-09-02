import math
def digitize(n):
    res = []
    while n != 0:
        res.append(math.floor(n % 10))
        n //= 10
    return res