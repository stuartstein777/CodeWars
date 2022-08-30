using System;
using System.Linq;
public static class Kata 
{
    public static int summation(int num)
      => Enumerable.Range(1, num).Sum();
}