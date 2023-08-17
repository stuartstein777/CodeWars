using System;
using System.Linq;
public static class JadenCase
{
  private static string ToTitleCase(string s)
    => System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s);
  
  public static string ToJadenCase(this string phrase)
    => string.Join(" ", phrase.Split(" ")
                              .Select(ToTitleCase));
}