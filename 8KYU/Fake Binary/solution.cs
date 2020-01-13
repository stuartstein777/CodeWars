using System.Linq;
public class Kata
{
  public static string FakeBin(string x)
    => string.Join("", x.ToCharArray().Select(c => (int)c < 53 ? '0' : '1'));
}