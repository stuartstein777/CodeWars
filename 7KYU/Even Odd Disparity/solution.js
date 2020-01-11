function solve(a){
  var evenCount = a.filter(i => Number.isInteger(i) && i % 2 == 0).length;
  var oddCount = a.filter(i => Number.isInteger(i) && i % 2 != 0).length;
  return evenCount - oddCount;
};