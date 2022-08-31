def solve(a,b):
    counts = []
    for x in b:
        counts.append(a.count(x))
    return counts