function squareArea(A){
    var sideLength = ((4 * A) / Math.PI) /2;
    return Number((sideLength * sideLength).toFixed(2));
}