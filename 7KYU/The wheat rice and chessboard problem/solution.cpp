unsigned int squaresNeeded(long long grains) {
  unsigned int cnt = 0;
  
  while(grains > 0) {
    grains /= 2;
    cnt++;
  }
  
  return cnt;
}