using System;

public static class Kata
{
  public static bool PowerOfTwo(int n) 
     => n == 0 ? false : (n & (n - 1)) == 0;
}