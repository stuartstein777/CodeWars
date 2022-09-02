def alternateCase(s):
    res = ""
    for c in s:
        if ord(c) >= 97 and ord(c) <= 122:
            res += str.upper(c)
        else:
            res += str.lower(c)
    return res