using System;

class Kata
{
  public static long Pentagonal(long n)
     => n <= 0 ? -1 : 1 + ((5 * (n-1) * n) / 2);
}