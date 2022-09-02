import re
def is_letter(s):
    return re.compile(r'[a-zA-Z]').match(s) != None and len(s) == 1