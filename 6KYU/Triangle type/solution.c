//  Should return triangle type
//  0 : if triangle cannot be made with given sides
//  1 : acute triangle
//  2 : right triangle
//  3 : obtuse triangle

int min(int a, int b) {
  return a < b ? a : b;
}

int max(int a, int b) {
  return a > b ? a : b;
}

int triangleType(int a, int b, int c) {

    if ((a + b <= c) || (a + c <= b) || (b + c) <= a) {
      return 0;
    }
    
    int t;
  
    if(a > b) {
      t = a;
      a = b;
      b = t;
    }
    if(a > c) {
      t = a;
      a = c;
      c = t;
    }
   if(c < b) {
     t = c;
     c = b;
     b = t;
   }

  int aa = a * a;
  int bb = b * b;
  int cc = c * c;
  
  if(aa + bb > cc) return 1;
  if(aa + bb == cc) return 2;
  return 3;
}
