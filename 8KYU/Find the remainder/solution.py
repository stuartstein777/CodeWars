def remainder(a,b):
    if a >= b:
        if b == 0:
            return None
        return a % b
    
    if a == 0:
        return None
    return b % a