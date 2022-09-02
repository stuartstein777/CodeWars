using System.Linq;
using System;
public class Kata
{
  public static double Solution(int[] firstArray, int[] secondArray)
      => firstArray.Select((t, i) => Math.Abs((t - secondArray[i]) * (t - secondArray[i]))).Sum() / (double)firstArray.Length;
}