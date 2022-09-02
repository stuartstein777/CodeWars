def draw_stairs(n):
    return '\n'.join(['I'.rjust(i, ' ') for i in range(1, n+1)])