using System.Linq;
public class Kata
{
  public static int[] PreFizz(int n) 
    => Enumerable.Range(1, n).ToArray();
}