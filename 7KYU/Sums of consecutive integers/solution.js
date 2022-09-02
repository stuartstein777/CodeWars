/**
 * Given the number of consecutive integers and the total of the integers,
 * return the consecutive integer at the requested position.
 *
 * @param {int} x number of consecutive integers
 * @param {int} y sum of consecutive integers
 * @param {int} n position of requested integer
 * @return {int} consecutive integer at requested position
 */
 function position(x, y, n) {
    var r = x * (x + 1)/2;
    return ((y-r)/x)+n+1;
  }