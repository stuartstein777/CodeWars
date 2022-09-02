def cat_mouse(x):
    if abs(x.index('m') - x.index('C')) <= 4:
        return "Caught!"
    return "Escaped!"