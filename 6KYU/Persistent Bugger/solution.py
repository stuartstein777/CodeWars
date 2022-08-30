def product_of_digits(n):
    r = [int(i) for i in str(n)]
    res = 1
    for i in r:
        res*= i
    return res
    
def persistence(n):
    cnt = 0
    v = n
    while v >= 10:
        v = product_of_digits(v)
        cnt+=1 
    return cnt