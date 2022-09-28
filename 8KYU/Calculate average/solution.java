public class Kata{
    public static double find_average(int[] array){
       double sum = 0.0;
      
       for(int i = 0; i < array.length; i++) {
         sum = sum + array[i];
       }
       return sum / array.length;
    }
}