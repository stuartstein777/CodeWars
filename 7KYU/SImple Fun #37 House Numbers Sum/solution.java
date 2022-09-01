public class Kata {
    public static int houseNumbersSum(final int[] arr) {
        int total = 0;
        
        for(int i = 0; i < arr.length; i++){
          if(arr[i] == 0)
            return total;
          total += arr[i];
        }
        return total;
    }
}