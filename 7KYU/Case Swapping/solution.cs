using System;
using System.Linq;
public static class Kata 
{
  public static string Swap(string str) 
    => string.Join("", str.ToCharArray()
                          .Select(c => char.IsUpper(c)
                                          ? char.ToLower(c)
                                          : char.ToUpper(c)));
}