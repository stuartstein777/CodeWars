using System.Linq;
public class Kata
{
  public static int[] Arr(int n)
    => Enumerable.Range(0, n).ToArray();
}