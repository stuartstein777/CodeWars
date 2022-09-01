int area_or_perimeter(int l, int w) {
  if(l == w)
    return l*w;
  return l + l + w + w;
}