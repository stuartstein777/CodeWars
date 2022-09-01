int odd_count(int n){
  int total = 0;
  for(int i = 1; i < n; i+=2) {
    if(i % 2 != 0)
      total ++;
  }
  return total;
}