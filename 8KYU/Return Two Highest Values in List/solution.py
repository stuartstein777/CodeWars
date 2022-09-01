def two_highest(arg1):
    print(arg1)
    if not arg1:
        return []
    if not type(arg1) is list:
        return False
        
    a = list(set(arg1))
    a.sort()
    b = a[-2:]
    b.reverse()
    return b
    