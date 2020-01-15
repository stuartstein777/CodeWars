using System.Linq;
public class Kata
{
  public static object[] TakeFirstElements(object[] array, int n = 1)
    => array.Where((_, i) => i < n).ToArray();
}