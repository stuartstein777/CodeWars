def greek_comparator(lhs, rhs):
    if greek_alphabet.index(lhs) > greek_alphabet.index(rhs):
        return 1
    elif greek_alphabet.index(lhs) < greek_alphabet.index(rhs):
        return -1
    return 0