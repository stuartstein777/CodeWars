using System;

public static class Kata
{
  public static string Greet(string name)
     => $"Hello {string.Concat(name[0].ToString().ToUpper(), name.ToLower().AsSpan(1))}!";
}
