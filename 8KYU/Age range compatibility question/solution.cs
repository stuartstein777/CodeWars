using System;
public class Kata
{
  public static string DatingRange(int age)
    => (age > 14)
          ? $"{Math.Floor((age/2.0)+7)}-{Math.Floor((age-7)*2.0)}"
          : $"{Math.Floor(age-(0.10*age))}-{Math.Floor(age+(0.10*age))}";
}