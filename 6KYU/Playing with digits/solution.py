def number_to_digits(n):
    return [int(i) for i in str(n)]

def get_sum(n, p):
    digits = number_to_digits(n)
    sum = 0
    while len(digits) > 0:
        sum += digits[0]**p
        digits = digits[1:]
        p+=1
    return sum


def dig_pow(n, p):
    v = get_sum(n, p)
    if v % n == 0:
        return v // n
    return -1