public class JosephusSurvivor {
  public static int josephusSurvivor(final int n, final int k) {
      int r = 0;
      int i = 1;
    
      while(i != n+1) {
         r = (r + k) % i;
         i++;
      }
      return r+1;
  }  
}