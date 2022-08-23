public class Kata {
    public static boolean betterThanAverage(int[] classPoints, int yourPoints) {
      int sum = 0;
      
      for(int i = 0; i < classPoints.length; i++) {
        sum += classPoints[i];
      }
      
      if(yourPoints >= sum / classPoints.length)
        return true;
      return false;
    }
  }