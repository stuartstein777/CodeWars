def positive_sum(arr):
    total = 0
    
    for i in arr:
        if i > 0:
            total = total + i
    return total
