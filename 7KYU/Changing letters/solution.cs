using System.Linq;

public static class Kata
{
  private static bool IsVowel(char c)
     => c == 'a' || c=='e' || c=='i' || c == 'o' || c=='u';
  
  public static string Swap(string s)
    => s.Aggregate("", (s, c) => s += IsVowel(c) ? char.ToUpper(c) : c);
}