def number(lines):
    n = 1
    res = []
    for line in lines:
        res.append(str(n) + ': ' + line)
        n+=1
    return res