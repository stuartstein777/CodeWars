using System;
using System.Linq;
public static class Kata
{
    public static string Disemvowel(string str)
      => string.Join("", str.ToCharArray().Where(c => !"AEIOUaeiou".Contains(c)));
}