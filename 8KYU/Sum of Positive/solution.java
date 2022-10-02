public class Positive{

  public static int sum(int[] arr){
    int total = 0;
    
    for(int i = 0; i < arr.length; i++) {
      if(arr[i] > 0) {
        total += arr[i];
      }
    }
    return total;
  }
}