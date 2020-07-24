const uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
const lowercase = "abcdefghijklmnopqrstuvwxyz";
const numbers = "0123456789";
function solve(str){
  var u = 0;
  var l = 0;
  var n = 0;
  var s = 0;
  for(var i = 0; i < str.length; i++) {
    if(uppercase.includes(str[i])) {
       u++;
    } else if(lowercase.includes(str[i])) {
      l++;
    } else if(numbers.includes(str[i])) {
      n++;
    } else {
      s ++;
    }   
  }
  return [u, l, n, s];
}
