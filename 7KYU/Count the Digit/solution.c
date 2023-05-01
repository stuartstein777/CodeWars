int getCount(int sq, int d) {
  
  int count = 0;
  if(sq == d) {
    return 1;
  }
  
  while(sq) {
    if(sq % 10 == d) {
      count++;
    }
    sq /= 10;
  }
  return count;
}

int nbDig(int n, int d) {
  int count = 0;
  
  for(int i = 0; i <= n; i++) {
    int sq = i * i;
    count += getCount(sq, d);
  }
  
  return count;
}