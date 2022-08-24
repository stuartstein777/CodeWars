import collections
def find_it(seq):
    d = collections.Counter(seq)
    result = {k:v for (k,v) in d.items() if v % 2 != 0}
    [(k, v)] = result.items()
    return k