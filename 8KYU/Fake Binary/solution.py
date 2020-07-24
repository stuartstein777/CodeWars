import re

def fake_bin(x):
    return re.sub('[5-9]', '1', re.sub('[0-4]', '0', x))
