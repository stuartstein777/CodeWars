import re
vowels = r'[aeiouAEIOU]'
def disemvowel(string):
    return re.sub(vowels, '', string, flags=re.IGNORECASE)