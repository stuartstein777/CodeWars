def hamming(a,b):
    l = len(a)
    res = 0
    for i in range(0, l):
        if a[i] != b[i]:
            res+= 1
    return res
            