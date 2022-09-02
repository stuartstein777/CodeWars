def odd_one(arr):
    index = 0
    for i in arr:
        if i % 2 != 0:
            return index
        index+=1
        
    return -1