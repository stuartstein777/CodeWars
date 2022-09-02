def josephus_survivor(n,k):
    r = 0
    i = 1
    while i != n+1:
        r = (r + k) % i
        i+=1
    return r+1