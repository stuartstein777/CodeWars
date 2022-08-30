using System.Linq;
using System;
public class Kata
{
  public static int Average(int[] scores)
    => (int)Math.Round(scores.Average());
}