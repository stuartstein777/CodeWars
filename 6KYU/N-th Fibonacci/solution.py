import math
def nth_fib(n):
    return round((((1 + math.sqrt(5)) / 2)**(n-1)) / math.sqrt(5), 0)