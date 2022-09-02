import re

def validate_usr(username):
    r = re.compile('^[a-z0-9_]*')
    return r.match(username).group() == username and len(username) >= 4 and len(username) <= 16