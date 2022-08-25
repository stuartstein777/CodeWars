using System;
using System.Linq;

public class Kata
{
  public static string Evil(int n)
    => Convert.ToString(n, 2).Count(c => c == '1') % 2 == 0
         ? "It's Evil!"
         : "It's Odious!";
}