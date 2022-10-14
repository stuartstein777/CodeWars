using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int Find(int[] integers)
  {
      return integers.GroupBy(x => x % 2 == 0)
                     .Where(g => g.Count() == 1)
                     .First()
                     .First();
  }
}