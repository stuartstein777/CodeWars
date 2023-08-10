public class Divisible {
    public static boolean isDivisible(int...args) {
        int n = args[0];
      
        for(int i = 0; i < args.length; i++) {
          if(n % args[i] != 0) {
             return false;
          }
        }
        return true;          
    }
}
