using System.Linq;

public class Kata
{
  public static string[] SortByLength (string[] array)
     => array.OrderBy(a => a.Length).ToArray();
}