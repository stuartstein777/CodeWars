using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{
  private static string DrawRow(int a, int b, int len)
  {
    var xs = new List<string>();
    for (var i = 0; i < len; i++)
    {
        if(i == a || i == b)
            xs.Add("■");
        else
            xs.Add("□");
    }
    return string.Join("", xs);
  }
  
  public static string X(int n)
  {
      var a = 0;
      var b = n - 1;
      var rows = new List<string>();
      while (a <= b)
      {
          rows.Add(DrawRow(a, b, n));
          a++;
          b--;
      }    
      return string.Join("\n", rows.Concat(rows.AsEnumerable().Reverse().Skip(1)).ToList());
  }
}