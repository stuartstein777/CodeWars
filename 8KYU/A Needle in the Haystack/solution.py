def find_needle(haystack):
    for idx, i in enumerate(haystack):
        if str(i) == 'needle':
            return "found the needle at position " + str(idx)
    return None
