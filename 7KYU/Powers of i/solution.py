def pofi(n):
    powers = {
        0: '1',
        1: 'i',
        2: '-1',
        3: '-i'
    }
    return powers.get(n % 4)

    