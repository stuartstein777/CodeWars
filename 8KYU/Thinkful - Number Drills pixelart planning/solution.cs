using System;

public static class Kata
{
  public static bool IsDivisible(int wallLength, int pixelSize)
    => wallLength % pixelSize == 0;
}