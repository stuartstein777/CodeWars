using System.Linq;
public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
    => a.Where(n => !b.Contains(n)).ToArray();
}