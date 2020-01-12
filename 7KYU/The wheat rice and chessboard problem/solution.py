import math
def squares_needed(grains):
    count = 0
    while grains > 0:
        grains = math.floor(grains / 2)
        count += 1
    return count