public class MaxMultiple {
    public static int maxMultiple(int divisor, int bound) {
      return bound - bound % divisor; 
    }
  }