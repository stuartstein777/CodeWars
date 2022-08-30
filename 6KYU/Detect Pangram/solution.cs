using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
  public static bool IsPangram(string s)
     => new Regex("[a-z]")
              .Matches(s.ToLower())
              .Select(m => m.Value)
              .ToHashSet()
              .Count() == 26;
}