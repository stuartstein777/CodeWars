using System;
using System.Text.RegularExpressions;

public static class Kata
{
  public static string Replace(string s) => new Regex("[aeiouAEIOU]").Replace(s,"!");
}