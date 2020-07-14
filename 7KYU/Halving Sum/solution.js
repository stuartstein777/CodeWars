function halvingSum(n){
  var a = 0;
  var d = 1;
  var res = 0;
  do {
    var a = Math.floor(n / d);
    d *= 2;
    res += a;   
  } while(a != 1);
  return res;
}
