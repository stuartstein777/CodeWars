def fizz_buzz_it(n):
    if n % 3 == 0 and n % 5 == 0:
        return 'FizzBuzz'
    elif n % 3 == 0:
        return 'Fizz'
    elif n % 5 == 0:
        return 'Buzz'
    return n
        
def fizzbuzz(upper):
    return [fizz_buzz_it(i) for i in range(1, upper+1)]
