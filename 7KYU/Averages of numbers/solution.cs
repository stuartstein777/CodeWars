using System.Linq;
public class Kata
{
  public static double[] Averages(int[] numbers)
    =>(numbers == null) 
        ? new double[0]
        : numbers.SkipLast(1).Select((x, i) => (x + numbers[i+1]) / 2.0).ToArray();
}