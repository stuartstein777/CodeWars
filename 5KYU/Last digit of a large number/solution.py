def last_digit(b, ex):
    if ex == 0:
        return 1
    # these are the patterns that are formed by the last digits of successive powers
    cycles = [[0], [1], [2, 4, 8, 6], [3, 9, 7, 1], [4, 6], [5], [6], [7, 9, 3, 1], [8, 4, 2, 6], [9, 1]]
    cycle_idx = int(b % 10)                   # get the last digit of the base, this tells us the cycle we want to use.
    final_digits_cycle = cycles[cycle_idx]    # this the cycle that our b^ex must be
    cycle_cnt_remainder = ex % len(final_digits_cycle) # get how many times the pattern repeats and the remainder of elements left over.

    if cycle_cnt_remainder == 0:    # if we have no left over elements of the pattern, then the last digit must be the last element from the patttern
        return final_digits_cycle[len(final_digits_cycle)-1]
    else:
        return final_digits_cycle[cycle_cnt_remainder - 1] #otherwise we get the element at the index of the remainder.