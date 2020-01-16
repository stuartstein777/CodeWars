using System;

public class Kata
{
  public static int Remainder(int a, int b)
    => (a >= b)
          ? a % b
          : b % a;
}