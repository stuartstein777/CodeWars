using System.Linq;

public class Kata
{
  public static int[] GetEvenNumbers(int[] numbers)
    => numbers.Where(n => n%2==0).ToArray();
}