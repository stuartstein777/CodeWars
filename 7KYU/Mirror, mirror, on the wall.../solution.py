def mirror(data: list) -> list:
    xs = sorted(data, reverse=True)
    return list(reversed(xs)) + xs[1:]