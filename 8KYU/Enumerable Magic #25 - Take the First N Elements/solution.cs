using System;
using System.Linq;

public static class Kata
{
    public static int[] Take(int[] arr, int n)
      => arr.Take(n).ToArray();
}