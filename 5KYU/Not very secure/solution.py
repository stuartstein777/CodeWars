import re

def alphanumeric(password):
    if len(password) == 0:
        return False
    
    return re.search("[^0-9a-zA-Z]", password) == None