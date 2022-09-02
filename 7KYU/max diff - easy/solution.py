def max_diff(lst):
  if len(lst) == 0:
    return 0
  else:
    return max(lst) - min(lst)