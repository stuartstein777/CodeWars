using System;

public static class Kata
{
  public static double Converter(int mpg)
     => Math.Round((mpg * 1.609344) / 4.54609188, 2);
}