public class Kata
{
  public static bool CorrectTail(string body, string tail)
    => tail.ToLower()[0] == body.ToLower()[body.Length-1];
}