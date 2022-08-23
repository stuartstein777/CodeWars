int containsFive(int n) {
  while(n != 0) {
    if(abs(n % 10) == 5) {
      return 1;
    }
    n /= 10;
  }
  return 0;
}

int dontGiveMeFive(int start, int end)
{
  int total = 0;
  for(int i = start; i <= end; i++) {
    if(containsFive(i) == 0){
      total++;
    }
  }
  return total;
}