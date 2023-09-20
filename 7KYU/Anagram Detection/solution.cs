using System.Linq;

public class Kata
{
  public static bool IsAnagram(string test, string original)
    => test.Length == original.Length && 
    !test.ToLower().ToCharArray().Except(original.ToLower().ToCharArray()).Any();
}