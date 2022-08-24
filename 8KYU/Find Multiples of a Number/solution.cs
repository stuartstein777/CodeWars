using System.Collections.Generic;
using System.Linq;
public class Kata
{
  public static List<int> FindMultiples(int integer, int limit)
    => Enumerable.Range(integer, (limit-integer)+1)
                 .Where(x => x % integer == 0)
                 .ToList();
}