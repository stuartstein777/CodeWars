switcheroo = (x) -> 
  return x.replace /[a-b]/g, (c) -> if c == 'a' then 'b' else 'a'