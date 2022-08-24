using System.Linq;
public class Kata
{
  public static string Contamination(string text, string character)
     => (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(character))
           ? string.Empty
           : string.Join("", Enumerable.Repeat(character, text.Length));
}