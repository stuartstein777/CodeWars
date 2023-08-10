typedef unsigned long long ull;

ull squares_needed(ull grains) {

  ull cnt = 0;
  
  while(grains > 0) {
    grains /= 2;
    cnt++;
  }
  
  return cnt;

}