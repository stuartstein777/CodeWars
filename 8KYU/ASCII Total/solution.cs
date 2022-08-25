using System.Linq;

public class Kata
{
  public static int UniTotal(string str)
     => str.Aggregate(0, (acc, i) => acc + i);
}