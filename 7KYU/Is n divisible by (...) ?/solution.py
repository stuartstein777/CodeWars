def is_divisible(*args):
    n = args[0]
    for i in range(1, len(args)):
        if n % args[i] != 0:
            return False
    return True