using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidateCode(string code) 
  {
    var regex = new Regex("^[1-3]");
    return regex.IsMatch(code);
  }
}