def power_of_two(x):
    if x == 0:
        return False
      
    return (x & (x - 1)) == 0