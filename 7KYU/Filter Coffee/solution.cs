using System;
using System.Linq;
public class Kata
{
  public static string Search(int budget, int[] prices)
    => string.Join(",", prices.Where(p => p <= budget).OrderBy(p => p));
}