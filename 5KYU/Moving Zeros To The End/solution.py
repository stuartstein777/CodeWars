def move_zeros(xs):
    non_zeros = [i for i in xs if i is False or i is None or i != 0]
    zeros = [i for i in xs if i == 0 and i is not False and i is not None]
    return non_zeros + zeros
      