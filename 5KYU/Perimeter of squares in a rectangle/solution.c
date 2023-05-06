typedef unsigned long long ull;
ull perimeter(int n) {
  ull a = 4;
  ull b = 4;
  ull total = 0;
  
  for(int i = 0; i <= n; i++) {
    total += a;
    ull c = a + b;
    a = b;
    b = c;
  } 
  return total;
}