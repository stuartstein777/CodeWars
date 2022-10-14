/*
  function:- stantonMeasure
  input:- integer array
  output:- stanton measure of the array
*/
function stantonMeasure(xs){
    let ones = xs.filter(x => x == 1).length;
    return xs.filter(x => x == ones).length;
}