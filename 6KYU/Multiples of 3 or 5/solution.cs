using System.Linq;
using System;
public static class Kata
{
  public static int Solution(int value)
    => (value == 0)
         ? 0
         : Enumerable.Range(1, (value-1))
                     .Where(n => n % 3 == 0 || n % 5 == 0)
                     .Sum();
}