def solve(s):
  if sum(1 for c in s if c.isupper()) > len(s) / 2:
    return s.upper()
  else:
    return s.lower()