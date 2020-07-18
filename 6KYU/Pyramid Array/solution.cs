using System;
using System.Linq;

public class Kata
{
  public static int[][] Pyramid(int n) 
    => Enumerable.Range(1, n)
                 .Select(x => Enumerable.Repeat(1, x).ToArray())
                 .ToArray();
}