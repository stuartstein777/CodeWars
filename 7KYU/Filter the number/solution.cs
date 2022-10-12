using System;
using System.Text.RegularExpressions;
public class Kata
{
  public static int FilterString(string s)
     =>int.Parse(Regex.Replace(s, "[^0-9]", ""));
}