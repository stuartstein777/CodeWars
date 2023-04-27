using System.Linq;
public class Kata
{
  public static int BetweenExtremes(int[] numbers)
  {
      return numbers.Max() - numbers.Min();
  }
}