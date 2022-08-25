using System.Linq;
public class Kata
{
  public static string Gordon(string a)
  {
    var words = a.Split(" ");
    return string.Join("!!!! ", words)
              .ToUpper()
              .Replace("A", "@")
              .Replace("E", "*")
              .Replace("I", "*")
              .Replace("O", "*")
              .Replace("U", "*") + "!!!!";
  }
}