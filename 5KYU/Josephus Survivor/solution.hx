class Kata {
    public static function josephusSurvivor(n: Int, k: Int): Int {
      var r = 0;
      var i = 1;
        
      while(i != n+1) {
        r = (r + k) % i;
        i++;
      }
      return r+1;
    }
}