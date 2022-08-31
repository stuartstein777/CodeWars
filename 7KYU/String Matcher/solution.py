def is_matching(s, s1, s2): 
    if sorted(s.replace(" ", "").lower()) == sorted((s1.replace(" ", "") + s2.replace(" ", "")).lower()):
          return True
    return False