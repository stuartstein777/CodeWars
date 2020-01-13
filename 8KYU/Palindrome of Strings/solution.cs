using System.Linq;
using System;
public class Kata
{
  public static bool IsPalindrome(object line)
    => string.Concat(line.ToString().ToCharArray().Reverse()) == line.ToString();
}