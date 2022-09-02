import math
def round_it(n):
    print(n)
    splits = str(n).split('.')
    if len(splits[0]) > len(splits[1]):
        return math.floor(n)
    elif len(splits[0]) < len(splits[1]):
        return math.ceil(n)
    return round(n)