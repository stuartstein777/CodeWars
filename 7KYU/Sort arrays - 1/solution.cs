using System.Linq;
public class Kata
{
  public static string[] SortMe(string[] names)
    => names.OrderBy(n => n).ToArray();
}