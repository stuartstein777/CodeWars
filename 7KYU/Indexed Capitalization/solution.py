def capitalize(str,ind):
    result = ""
    for idx, s in enumerate(str):
        if idx in ind:
            result += s.upper()
        else:
            result += s
    return result
