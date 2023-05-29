Copy to clipboardusing System;

public static class Kata
{
  public static string Nerdify(string str)
  {
      if(str == null) throw new ArgumentNullException();
      return str.Replace("a", "4")
                .Replace("A", "4")
                .Replace("e", "3")
                .Replace("E", "3")
                .Replace("l", "1");
  }
}