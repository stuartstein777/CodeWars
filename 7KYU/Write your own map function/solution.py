def map(function, iterable):
    res = []
    
    for i in iterable:
        res.append(function(i))
    return res
