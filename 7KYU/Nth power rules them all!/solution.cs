using System.Linq;
using System;
public class Kata
{
  public static int ModifiedSum(int[] a, int n)
    => a.Select(i => int.Parse(Math.Pow(i, n).ToString()))
        .Sum() - a.Sum();    
}