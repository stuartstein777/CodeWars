import math
def nb_year(p0, percent, aug, p):
    years = 0
    while p0 < p:
        p0 = math.floor(p0 + aug + (p0 * percent  / 100))
        years+=1
    return years