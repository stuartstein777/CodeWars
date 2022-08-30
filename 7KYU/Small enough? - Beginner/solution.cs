using System.Linq;
public class Kata
{
  public static bool SmallEnough(int[] a, int limit)
    => a.OrderBy(x => x).Last() <= limit;
}