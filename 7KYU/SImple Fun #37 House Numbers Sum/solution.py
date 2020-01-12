def house_numbers_sum(inp):
    print(inp)
    total = 0
    for i in inp[::-1]:
        if i == 0:
            total = 0
        else:
            total += i
    return total