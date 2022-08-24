import collections
def duplicate_count(text):
    x = collections.Counter(list(text.lower()))
    items = [i for i in x.values() if i > 1]
    return len(items)