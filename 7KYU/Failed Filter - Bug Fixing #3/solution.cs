using System;
using System.Linq;

public class Kata
{
  public static string FilterNumbers(string str)
    => string.Join("", str.ToCharArray().Where(c => !Char.IsDigit(c)));
}