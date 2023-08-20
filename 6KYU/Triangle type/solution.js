/* Should return ᐃ type:
  0 : if ᐃ cannot be made with given sides
  1 : acute ᐃ
  2 : right ᐃ
  3 : obtuse ᐃ
*/

function triangleType(a, b, c){

  if ((a + b <= c) || (a + c <= b) || (b + c) <= a) {
      return 0;
  }
  
  var t;
  
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

  let aa = a * a;
  let bb = b * b;
  let cc = c * c;
  
  if(aa + bb > cc) return 1;
  if(aa + bb == cc) return 2;
  return 3;
}