using System;
using System.Linq;
public static class Kata
{
  public static string RemoveDuplicateWords(string s)
    => string.Join(" ", s.Split(' ').Distinct());
}