using System.Collections.Generic;
using System.Linq;
public class Kata
{
  public static List<int> Largest(int n, List<int> xs)
    => xs.OrderByDescending(x => x)
         .Take(n)
         .OrderBy(x => x)
         .ToList();
}