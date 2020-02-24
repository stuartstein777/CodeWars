function mostLikely(prob1,prob2){
  var p1split = prob1.split(':');
  var p2split = prob2.split(':');
  var p1 = Number(p1split[0]) / Number(p1split[1])
  var p2 = Number(p2split[0]) / Number(p2split[1]);
  
  return p1 > p2;
}