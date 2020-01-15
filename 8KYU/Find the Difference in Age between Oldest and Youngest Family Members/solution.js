function differenceInAges(ages){
  var oldest = Math.max.apply(null,ages);
  var youngest = Math.min.apply(null,ages);
  return [youngest,oldest,oldest-youngest];
}