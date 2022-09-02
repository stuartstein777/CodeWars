def hamming_distance(a, b):
    z = a ^ b
    i = 0
    while z != 0:
        zn = z - 1
        z &= zn
        i += 1
    return i