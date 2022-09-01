using System;

public class Kata
{
  public static bool CheckForFactor(int num, int factor)
  {
    Math.DivRem(num, factor, out var res);
    return res == 0;
  }
}