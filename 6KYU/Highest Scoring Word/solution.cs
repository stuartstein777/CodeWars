using System.Linq;
public static class Kata
{
  private static int ScoreWord(string word)
    => word.Aggregate(0, (acc, i) => acc + (int)i - 96);
  
  public static string High(string s)
    => s.ToLower()
        .Split(" ")
        .Select(w => (Score: ScoreWord(w), Word: w))
        .MaxBy(ws => ws.Score)
        .Word;
}