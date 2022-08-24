using System;
using System.Linq;
public static class Kata
{
  public static string HighAndLow(string numbers)
  {
      var sorted = numbers.Split(" ").Select(int.Parse).OrderByDescending(c => c);
      return $"{sorted.First()} {sorted.Last()}";
  }
}