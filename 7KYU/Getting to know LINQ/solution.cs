using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static int Sum(int[] integers)
    => integers.Sum();
 
  public static int CountChar(char[] chars, char charToCount)
    => chars.Count(c => c == charToCount);
 
  public static int[] CalculateSquares(int start, int end)
    => Enumerable.Range(start, (end-start+1)).Select(i => i*i).ToArray();
}