def is_in_middle(sequence):
    abcIdxs = [i for i in range(len(sequence)) if sequence.startswith('abc', i)]
    for idx in abcIdxs:    
        l = len(sequence[0:idx])
        r = len(sequence[(idx+3)::])  
        if abs(l - r) <= 1:
            return True
    return False