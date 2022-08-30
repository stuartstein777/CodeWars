def solve(arr): 
    rev = arr[::-1]
    res = []
    for x in rev:
        if x not in res:
            res.append(x)
    return res[::-1]