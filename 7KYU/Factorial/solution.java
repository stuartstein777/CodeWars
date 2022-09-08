public class Factorial {

    public static long factorial(int n) {
      long res = 1;
      
      for(int i = 1; i <= n; i++) {
        res *= i;
      }
      return res;
    }
}
