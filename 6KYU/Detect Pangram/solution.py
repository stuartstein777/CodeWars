import re

def is_pangram(s):
    r = re.compile(r'[a-z]')
    if len(set(r.findall(s.lower()))) == 26:
        return True
    return False