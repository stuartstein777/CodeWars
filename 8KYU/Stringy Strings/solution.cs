using System.Linq;
public class Kata
{
  public static string Stringy(int size)
    => string.Concat(Enumerable.Range(0, size).Select(c => c % 2 == 0 ? "1" : "0"));
}