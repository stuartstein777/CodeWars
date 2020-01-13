function nearestSq(n){
  var sqrt = Math.sqrt(n);
  var floor = Math.floor(sqrt);
  var ceiling = Math.ceil(sqrt);  
  var floorDiff = Math.abs(n - (floor*floor));
  var ceilingDiff = Math.abs(n - (ceiling*ceiling));
  if(floorDiff > ceilingDiff)
    return ceiling*ceiling;
  return floor*floor;
}
