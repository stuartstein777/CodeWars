int get_sum(int a, int b)
{
  int start = a, end = b;
  
  if(a > b) {
    start = b;
    end = a;
  }
  
  int total = 0;
  for(int i = start; i <= end; i++){
    total += i;
  }
  return total;
}