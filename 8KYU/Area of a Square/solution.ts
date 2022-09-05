export const squareArea = (num : number) : number =>  {
    var sideLength = ((4 * num) / Math.PI) /2;
    return Number((sideLength * sideLength).toFixed(2));
}