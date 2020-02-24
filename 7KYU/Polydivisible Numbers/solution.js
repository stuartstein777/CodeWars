function polydivisible(x) {
  console.log(x);
  var s = x.toString();
  for(var i = 1; i <= s.length; i++){
    var sub = s.substring(0, i);
    console.log(sub);
    if(Number(sub) % i != 0){
      return false;
    }
  }
  return true;
}