using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int DuplicateCount(string str)
      => str.ToLower()
            .ToCharArray()
            .Frequencies()
            .Where(kv => kv.Value >= 2)
            .Select(kv => kv.Value)
            .Count();
}

public static class CodewarExtensions
{
  public static Dictionary<T, int> Frequencies<T>(this IEnumerable<T> xs) where T : notnull
  {
     var res = new Dictionary<T, int>();
     foreach (var x in xs)
     {
        if (res.ContainsKey(x))
           res[x]++;
        else
           res.Add(x, 1);
     }
     return res;
  }
}