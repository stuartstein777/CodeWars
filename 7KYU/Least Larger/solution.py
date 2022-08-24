def least_larger(a, i): 
    res = None
    for idx, n in enumerate(a, start=0):
        if n > a[i] and (res == None or n < a[res]):
            res = idx
    if res == None:
        return -1
    return res