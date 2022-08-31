using System.Linq;
public class Kata
{
  public static int SumMix(object[] x)
    => x.Aggregate(0, (acc, i) => acc + int.Parse(i.ToString()));
}