public class FindOdd {
	public static int findIt(int[] a) {
  	
    int x = a[0];
    
    for(int i = 1; i < a.length; i++) {
      x = x ^ a[i];
    }
    
    return x;
    
  }
}