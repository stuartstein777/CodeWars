namespace Code
{
  using System.Linq;
  public class Unique
  {
    public static bool HasUniqueChars(string str)
       => str.ToCharArray().Distinct().Count() == str.Length;
  }
}