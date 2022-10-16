using System;

public class Kata
{
  public static double CalculateTotal(double subtotal, int tax, int tip)
  {
     return Math.Round(subtotal + (subtotal * (tip / 100.0)) + (subtotal * (tax / 100.0)), 2);
  }
}