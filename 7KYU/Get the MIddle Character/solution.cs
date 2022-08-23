using System;
using System.Linq;

public class Kata
{
  public static string GetMiddle(string s)
        => (s.Length % 2 == 0)
            ? string.Join("", s.ToCharArray().Skip((s.Length - 2) / 2).Take(2))
            : s.ToCharArray().Skip((int)Math.Floor((double)(s.Length /2))).Take(1).First().ToString();
}