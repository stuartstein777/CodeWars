public class Kata
{
  public static string UefaEuro2016(string[] teams, int[] scores)
  {
    if(scores[0] == scores[1])
      return $"At match {teams[0]} - {teams[1]}, teams played draw.";
    else if(scores[0] > scores[1])
      return $"At match {teams[0]} - {teams[1]}, {teams[0]} won!";
    else
      return $"At match {teams[0]} - {teams[1]}, {teams[1]} won!";
  }
}