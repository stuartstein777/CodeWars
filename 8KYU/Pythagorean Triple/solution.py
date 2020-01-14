def pythagorean_triple(integers):
    a = (integers[0] * integers[0])
    b = (integers[1] * integers[1])
    c = (integers[2] * integers[2])
    return (a + b == c) or (a + c == b) or (b + c == a)