def maskify(cc):
    if len(cc) <= 4:
        return cc
    else:
        return "#"*(len(cc)-4) + cc[len(cc)-4::]
        