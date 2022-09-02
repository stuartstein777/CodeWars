def productFib(n):
    a = 0
    b = 1
    while True:
        if n == (a * b):
            return [a, b, True]
        elif (a * b) > n:
            return [a, b, False]
        else:
            t = a
            a = b
            b = t +a