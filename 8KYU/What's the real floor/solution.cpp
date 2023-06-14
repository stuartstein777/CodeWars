int getRealFloor(int f) {
  
  switch (f) {
  case 0:
    return 0;
  case 1 ... 12:
    return f - 1;
  default:
    return f < 0 ? f : f - 2;
  }
}