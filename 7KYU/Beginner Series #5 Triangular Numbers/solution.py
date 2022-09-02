import math
def is_triangular(t):
    sol = (math.sqrt((1 + (8 * t))) - 1) * 0.5;
    return sol == math.floor(sol);
