using System.Text.RegularExpressions;
public class Kata
{
  public static string StringClean(string s)
    => Regex.Replace(s, @"[\d-]", string.Empty);
}