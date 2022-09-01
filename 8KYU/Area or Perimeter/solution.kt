object Solution {
  fun areaOrPerimeter(l:Int, w:Int):Int {
    if(l == w)
        return l*w;
    return l*2 + w*2;
  }
}