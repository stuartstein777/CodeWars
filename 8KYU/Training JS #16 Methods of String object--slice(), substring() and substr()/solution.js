function cutIt(arr){
  var shortest = arr.reduce((a, b) => a.length <= b.length ? a : b, 0).length;
  return arr.map(s => s.slice(0, shortest));
}