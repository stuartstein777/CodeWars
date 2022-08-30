using System;
using System.Linq;
public static class Kata
{
  public static int WordsToMarks(string str)
    => str.ToCharArray()
          .Select(c => (int)c - 96)
          .Sum();
}