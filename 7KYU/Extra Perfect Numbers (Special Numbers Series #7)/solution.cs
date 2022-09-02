using System.Collections.Generic;
using System.Linq;
using System;
public class Kata
{
  public static int[] ExtraPerfect(int n)
    => Enumerable.Range(1, n)
                 .Where(x => Convert.ToString(x, 2).StartsWith("1") &&
                             Convert.ToString(x, 2).EndsWith("1"))
                 .ToArray();
}