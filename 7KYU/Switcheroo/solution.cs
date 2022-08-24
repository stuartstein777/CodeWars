public class Kata
{
  public static string Switcheroo(string x)
  {
      return x.Replace("a", "~")
              .Replace("b", "a")
              .Replace("~", "b");
  }
}