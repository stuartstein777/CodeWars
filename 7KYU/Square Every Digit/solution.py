def square_digits(num):
    digits = [int(x)**2 for x in str(num)]
    return int(''.join([str(i) for i in digits]))
    