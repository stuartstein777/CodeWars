class Kata {
  static int josephusSurvivor(int n, int k) {
      int r = 0
      int i = 1
    
      while(i != n+1){
        r = (r + k) % i
        i++
      }
      return r+1
  }
}