function symmetricPoint(p, q) {
  return [(p[0] + ((q[0]-p[0])*2)), (p[1] + ((q[1]-p[1])*2))];
}