areaOrPerimeter = (l, w) -> 
  if(l == w)
    return l*w;
  return l+l+w+w;