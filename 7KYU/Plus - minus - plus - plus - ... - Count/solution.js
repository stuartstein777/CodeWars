function catchSignChange(arr) {
  var res = 0;
  var last = arr[0] < 0;
  for(var i = 1; i < arr.length; i++) {
      var curr = arr[i] < 0;
      if (last !== curr) {
        res++;
      }
      last = curr;
  }
  return res;
}
