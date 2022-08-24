using System.Linq;
public static class MonkeyCounter
{
  public static int[] MonkeyCount(int n)
    => Enumerable.Range(1, n).ToArray();
}