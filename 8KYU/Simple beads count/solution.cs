using System;

public static class Kata
{
  public static int CountRedBeads(int n)
    => n < 2 ? 0 : (n-1) * 2;
}