def countBits(n):
    return len([i for i in bin(n) if i == '1'])