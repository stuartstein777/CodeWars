def pattern(n):
    return "\n".join(map(lambda x: str(x) * x, range(1, n+1)))
