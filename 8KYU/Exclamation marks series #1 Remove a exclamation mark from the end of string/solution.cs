public class Kata
{
  public static string Remove(string s)
    => s[s.Length-1] == '!'
        ? s.Substring(0, s.Length-1)
        : s;
}