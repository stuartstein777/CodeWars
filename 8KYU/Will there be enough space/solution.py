def enough(cap, on, wait):
    return 0 if on + wait <= cap else wait - (cap - on)