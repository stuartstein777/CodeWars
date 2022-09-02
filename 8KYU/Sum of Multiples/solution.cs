using System;
using System.Linq;
public class Kata
{
  public static int SumMul(int n, int m)
  {
    Console.WriteLine($"{n} {m}");
    if(n <= 0 || m <= 0 || m < n || m == n)
      throw new ArgumentException();
    return Enumerable.Range(n, (m-n))
                     .Where(x => x % n == 0)
                     .Sum();
  }
}