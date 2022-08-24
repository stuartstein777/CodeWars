int get_sum(int a , int b) {
  int start, end;
  
  if(a > b) {
    start = b;
    end = a;
  } else {
    start = a;
    end = b;
  }
  
  int total = 0;
  for(int i = start; i <= end; i++){
    total += i;
  }
  return total;
}