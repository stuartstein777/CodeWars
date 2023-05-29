using System.Linq;
public class Kata
{
  public static int MaxProduct(int[] array)
  {
      var topTwo = array.OrderByDescending(c => c)
                        .Take(2)
                        .ToArray();
      return topTwo[0] * topTwo[1];
  }
}