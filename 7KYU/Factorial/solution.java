public class Factorial {

    public int factorial(int n) {
      if(n < 0 || n > 12)
        throw new IllegalArgumentException("argh!");
        
      int total = 1;
      for(int i = 1; i <= n; i++)
        total *= i;
      return total;
    }
  }