def even_chars(st): 
    if len(st) < 2 or len(st) > 100:
        return 'invalid string'
    res = []
    for idx, i in enumerate(st):
        if idx % 2 != 0:
            res.append(i)
    return res