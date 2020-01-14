using System;
public class CodeWars
{
  public static bool IsDigit(string s) 
    => (double.TryParse(s, out var _));      
}