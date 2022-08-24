using System;
using System.Linq;

public static class Kata
{
  public static string GenerateShape(int n)
     => string.Join("\n", Enumerable.Repeat(string.Join("",Enumerable.Repeat('+', n)), n));
}