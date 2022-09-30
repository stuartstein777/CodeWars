public class TenMinWalk {
  public static boolean isValid(char[] walk) {
    int ns = 0; int ew = 0;
    
    for(int i = 0; i < walk.length; i++) {
      if(walk[i] == 'n') {
        ns++;
      } else if(walk[i] == 's') {
        ns--;
      } else if(walk[i] == 'e') {
        ew++;
      }
      if(walk[i] == 'w') {
        ew--;
      }
    }
    return walk.length == 10 && ns == 0 && ew == 0;
  }
}