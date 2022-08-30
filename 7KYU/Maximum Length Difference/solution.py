def mxdiflg(a1, a2):
    if len(a1) == 0 or len(a2) == 0:
        return -1
    a1_counts = [len(i) for i in a1]
    a2_counts = [len(i) for i in a2]
    
    a1_max = max(a1_counts)
    a2_max = max(a2_counts)
    a1_min = min(a1_counts)
    a2_min = min(a2_counts)
    
    max_diff_a1_a2 = a1_max - a2_min
    max_diff_a2_a1 = a2_max - a1_min
    
    if max_diff_a1_a2 > max_diff_a2_a1:
        return max_diff_a1_a2
    return max_diff_a2_a1