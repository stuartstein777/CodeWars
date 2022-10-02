public class Kata {
    public static boolean inviteMoreWomen(int[] l) {
        int total = 0;
      
        for(int i = 0; i < l.length; i++) {
          total = total + l[i];
        }
        return total > 0;
    }
}