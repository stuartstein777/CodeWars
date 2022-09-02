def solution(s):
    padded = s if len(s) % 2 == 0 else s + "_"
    res = []
    for _, idx in enumerate(range(0, len(padded), 2)):
        res.append(padded[idx] + padded[idx+1])
    return res