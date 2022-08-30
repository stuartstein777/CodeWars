def solve(arr):
    alphabet = "abcdefghijklmnopqrstuvwxyz"
    matches = []
    for s in arr:
        count = 0
        for i, e in enumerate(s.lower()): 
            if i == alphabet.find(e):
                count = count + 1
        matches.append(count)
    return matches