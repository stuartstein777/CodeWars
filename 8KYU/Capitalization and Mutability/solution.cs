public class Kata
{
  public static string CapitalizeWord(string word)
     => char.ToUpper(word[0]) + word.Substring(1);
}