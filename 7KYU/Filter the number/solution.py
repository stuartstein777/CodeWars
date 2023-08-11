import re

def filter_string(string):
    return int(re.sub("[^0-9]", "", string))
    