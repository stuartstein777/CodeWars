using System;
using System.Linq;

public static class Kata
{
  public static string ToCsvText(int[][] arr)
     => arr.Aggregate("", (acc, i) => acc + string.Join(',', i) + "\n").TrimEnd('\n');
}