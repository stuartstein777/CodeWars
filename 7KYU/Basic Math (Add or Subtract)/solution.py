import re
def calculate(s):
    operands = re.compile('[0-9]+').findall(s)
    operators = re.compile('plus|minus').findall(s)
    total = int(operands[0])
    for i in range(1, len(operands)):
        if operators[i-1] == 'plus':
            total += int(operands[i])
        else:
            total -= int(operands[i])
    return str(total)