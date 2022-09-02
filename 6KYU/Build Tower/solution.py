def tower_builder(n):
    max = (n *2)-1
    return [''.rjust((max-i)//2, ' ') + '*'*i + ''.rjust((max-i)//2, ' ') for i in range(1, (n*2), 2)]