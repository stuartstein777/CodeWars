import math
def get_middle(s):
    length = len(s)
    if length % 2 != 0:
        return str(s[math.floor(length / 2)])
    else:
        return str(s[math.floor(length / 2)-1]) + str(s[math.floor(length / 2)])