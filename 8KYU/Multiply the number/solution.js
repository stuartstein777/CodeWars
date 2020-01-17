function multiply(number){
  var n = `${Math.abs(number)}`.length;
  var b = Math.pow(5, n);
  return number * b;
}