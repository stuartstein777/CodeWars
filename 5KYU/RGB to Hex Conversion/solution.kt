fun clamp(min: Int, max: Int, n: Int): Int {
    if(n < min) {
        return min;
    } else if (n > max) {
        return max;
    }
    return n;
}

fun rgb(r: Int, g: Int, b: Int): String {
  var rc = clamp(0, 255, r);
  var gc = clamp(0, 255, g);
  var bc = clamp(0, 255, b);
  
  return (rc.toString(16).padStart(2, '0') + gc.toString(16).padStart(2, '0') + bc.toString(16).padStart(2, '0')).uppercase();
}