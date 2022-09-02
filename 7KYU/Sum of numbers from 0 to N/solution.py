def show_sequence(n):
    print(n)
    if n == 0:
        return "0=0"
    elif n < 0:
        return str(n) + "<0"
    else:
        res = "0"
        total = 0
        for num in range(1,n+1):
            res = res + f"+{num}"
            total = total + num
          
        return res + f" = {total}"