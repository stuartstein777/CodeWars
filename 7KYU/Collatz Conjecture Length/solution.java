public class Collatz {
    public static long conjecture(long x) {
      int c = 1;
      
      while(x != 1) {
        c++;
        if(x % 2 == 0)
          x /= 2;
        else
          x = x * 3 + 1;
      }
      return c;
    }
}