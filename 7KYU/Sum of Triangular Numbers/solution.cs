using System.Linq;
public class Kata
{
  public static int SumTriangularNumbers(int n)
    => n < 0 ? 0 : Enumerable.Range(1, n).Aggregate(0, (acc, i) => acc + (i * (1 + i)) / 2);
}