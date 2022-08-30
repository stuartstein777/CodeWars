using System;
using System.Linq;
public class Kata
{
  private const string Valid = "0123456789";
  public static bool ValidatePin(string pin)
  {
    return (pin.Length == 4 || pin.Length == 6) &&
           (pin.All(Valid.Contains));
  }
}