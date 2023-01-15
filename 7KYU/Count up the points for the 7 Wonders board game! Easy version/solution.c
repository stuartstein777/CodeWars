unsigned int min(unsigned int a, unsigned int b, unsigned int c) {
  if(a <= b && a <= c) {
    return a;
  } else if (b <= a && b <= c) {
    return b;
  }
  return c;
}

unsigned int seven_wonders_science(unsigned int compasses, unsigned int gears, unsigned int tablets) {
  return compasses * compasses +
         gears * gears +
         tablets * tablets +
         min(compasses, gears, tablets) * 7;
}