def count_positives_sum_negatives(arr):
    if arr == []:
        return []
    pos = len([i for i in arr if i > 0])
    neg = sum([i for i in arr if i < 0])
    return [pos, neg]