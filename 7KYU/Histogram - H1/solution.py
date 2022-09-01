def getEndCount(n):
    if n == 0:
      return ""
    return " " + str(n);

def histogram(n):
    solution = []
    for i in range(1, 7):
      solution.append(str(7-i) + "|" + ("#" * n[6-i]) + getEndCount(n[6-i]))
    return "\n".join(solution)  + "\n"