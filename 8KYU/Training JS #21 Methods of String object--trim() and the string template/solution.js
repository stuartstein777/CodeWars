function fiveLine(s){
  var n = s.trimRight().trimLeft();
  return [2,3,4,5].reduce((acc, i) => acc + "\n" + n.repeat(i), n)
}