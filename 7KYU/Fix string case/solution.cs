using System.Linq;
class Kata
{
    public static string Solve(string s)
      => s.ToCharArray().Count(c => char.IsLower(c)) >= s.Length / 2
          ? s.ToLower()
          : s.ToUpper();
}