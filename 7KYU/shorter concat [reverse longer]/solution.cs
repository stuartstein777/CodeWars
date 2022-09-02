using System;
class ReverseLonger
{
  public static string ShorterReverseLonger(string a, string b)
  {
    if (string.IsNullOrEmpty(a))
      a = string.Empty;
    if (string.IsNullOrEmpty(b))
      b = string.Empty;
    return (a.Length < b.Length)
              ? $"{a}{Reverse(b)}{a}"
              : $"{b}{Reverse(a)}{b}";
  }
  private static string Reverse(string s)
  {
    var arr = s.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
  }
}