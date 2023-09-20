using System.Linq;
public partial class Kata
{
  public static string MakeString(string s)
    => string.Join("", s.Split(" ").Select(s => s[0]));     
}