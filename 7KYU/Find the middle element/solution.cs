using System.Linq;
using System;

public class Kata
{
  public static int Gimme(double[] inputArray)
     => Array.FindIndex(inputArray, n => n == inputArray.OrderBy(n => n).ElementAt(1));
}