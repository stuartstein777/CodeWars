using System.Linq;
public class Kata
{
  public static string SortGiftCode(string code)
    => string.Join("", code.ToCharArray().OrderBy(x => x));
}