def is_valid_walk(walk):
    nesw = {
        'n': 0,
        'e': 0,
        's': 0,
        'w': 0,
    }
    
    for d in walk:
        if d in nesw:
            nesw[d] = nesw[d]+1
    
    return len(walk) == 10 and nesw['n'] == nesw['s'] and nesw['w'] == nesw['e']