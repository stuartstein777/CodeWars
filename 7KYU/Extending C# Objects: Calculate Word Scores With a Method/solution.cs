using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CustomExtensions
{
  public static class Extensions
  {
     public static int Score(this string s)
       => Regex.Replace(s, @"[^a-zA-Z]", "")
               .ToLower()
               .Aggregate(0, (acc, i) => acc + i - 96);
  }
}