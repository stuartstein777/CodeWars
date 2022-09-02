def is_triangle_number(number):
    print(number)
    if type(number) != int:
        return False
    
    if number == 0:
        return True
    sum = 0
    n = 1
    while n <= number:
        sum = sum + n
        if sum == number:
            return True
        n = n + 1
    return False