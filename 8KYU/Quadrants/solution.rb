def quadrant(x, y)
    return 1 if x > 0 and y > 0
    return 2 if x < 0 and y > 0
    return 3 if x < 0 and y < 0
    return 4
end