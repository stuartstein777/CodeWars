def multiple_of_3_or_5(n):
    return n % 3 == 0 or n % 5 == 0

def solution(number):
    return sum([i for i in range(1, number) if multiple_of_3_or_5(i)])
  