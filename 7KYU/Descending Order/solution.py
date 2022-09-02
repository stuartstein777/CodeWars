def descending_order(num):
    digits = [int(x) for x in str(num)]
    digits.sort(reverse=True)
    return int("".join([str(i) for i in digits ]))