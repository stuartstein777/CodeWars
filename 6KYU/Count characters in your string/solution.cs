using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static Dictionary<char, int> Count(string str)
    => str.GroupBy(c => c)
          .ToDictionary(c => c.Key, c => c.Count());
}