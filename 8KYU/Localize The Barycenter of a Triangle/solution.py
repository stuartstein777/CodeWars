import math
def bar_triang(a, b, c): # points A, B and C will never be aligned
    x = round(((a[0] + b[0] + c[0]) / 3), 4)
    y = round(((a[1] + b[1] + c[1]) / 3), 4)
    return [x, y]