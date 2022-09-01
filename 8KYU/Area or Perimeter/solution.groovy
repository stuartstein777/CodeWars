class Solution {
  static areaOrPerimter(int l, int w) {
      if(l == w)
        return l*w;
      return l + l + w + w;
  }
}