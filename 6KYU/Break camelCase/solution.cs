using System.Text.RegularExpressions;
public class Kata
{
  public static string BreakCamelCase(string str)
    => string.Join(" ", Regex.Split(str, @"(?<!^)(?=[A-Z])"));
}