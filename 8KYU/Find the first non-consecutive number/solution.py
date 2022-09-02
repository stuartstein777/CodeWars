def first_non_consecutive(arr):
    for idx in range(0, len(arr)-1):
        if arr[idx+1] - arr[idx] > 1:
            return arr[idx+1]
    return None
