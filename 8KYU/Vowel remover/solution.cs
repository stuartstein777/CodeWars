using System.Text.RegularExpressions;

public class Kata
{
  public static string Shortcut(string input)
     => Regex.Replace(input, @"[aeiou]", "");
}