using System.Text.RegularExpressions;

public class Kata
{
  public static bool Alphanumeric(string str)
    => !string.IsNullOrEmpty(str) && !Regex.IsMatch(str, "[^a-zA-Z0-9]");
}