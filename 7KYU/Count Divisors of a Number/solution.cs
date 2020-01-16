using System.Linq;
public class Kata
{
  public static int Divisors(int n)
  {
    return Enumerable.Range(1, n+1)
                   	 .Where(x => n % x == 0)
                   	 .Count();
  }
}