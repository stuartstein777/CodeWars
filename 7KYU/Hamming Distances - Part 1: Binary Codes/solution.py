def hamming_distance(a, b):
    res = 0
    for i in range(0,len(a)):
        if a[i] != b[i]:
            res+=1
    return res