using System.Linq;
public static class Kata
{
  public static int sumTwoSmallestNumbers(int[] numbers)
    => numbers.OrderBy(c => c).Take(2).Sum();
}