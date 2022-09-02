def score(word):
    res = 1
    for w in word:
        res *= ord(w) - 64
    return res

def ride(group,comet):
    if score(group) % 47 == score(comet) % 47:
        return "GO"
    return "STAY"