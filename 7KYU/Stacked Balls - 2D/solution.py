import math
def stack_height_2d(n):
    if n == 0:
        return 0
    else:
        return math.sqrt(((n - 1.0) ** 2) - (((n - 1.0) / 2.0) ** 2)) + 1