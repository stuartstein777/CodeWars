def find_the_ball(start, swaps):
    if len(swaps) == 0:
        return start
    else:
        x = swaps[0][0]
        y = swaps[0][1]
        if x == start:
            return find_the_ball(y, swaps[1::])
        elif y == start:
            return find_the_ball(x, swaps[1::])
        else:
            return find_the_ball(start, swaps[1::])