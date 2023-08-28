using System.Linq;
public class Kata
{
  public static int FindLongest(int[] number)
    => number.MaxBy((n) => n.ToString().Length);
}