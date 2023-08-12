def two_are_positive(a, b, c):
    return ((a > 0 and b > 0 and c <= 0) or
           (a > 0 and b <= 0 and c > 0) or
           (a <= 0 and b > 0 and c > 0))