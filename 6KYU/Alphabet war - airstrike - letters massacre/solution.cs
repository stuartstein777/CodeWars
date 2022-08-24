using System.Collections.Generic;
using System.Text;

public class Kata
{
  private static Dictionary<char, int> leftScores = new()
  {
      {'w', 4},{'p', 3},{'b', 2},{'s', 1}
  };

  private static Dictionary<char, int> rightScores = new()
  {
      {'m', 4},{'q', 3},{'d', 2},{'z', 1}
  };

  static string Explode(string fight)
  {
      var sb = new StringBuilder(fight);
      for (var i = 0; i < fight.Length; i++)
      {
          if (fight[i] == '*')
          {
              sb[i] = '_';
              if (i > 0)
                  sb[i - 1] = '_';

              if (i < fight.Length - 1)
                  sb[i + 1] = '_';
          }
      }
      return sb.ToString();
  }

  public static string AlphabetWar(string fight)
  {
      var exploded = Explode(fight);
      var leftScore = 0;
      var rightScore = 0;

      foreach (var x in Explode(fight).ToCharArray())
      {
          if (leftScores.ContainsKey(x))
              leftScore += leftScores[x];
          if (rightScores.ContainsKey(x))
              rightScore += rightScores[x];
      }

      if(leftScore > rightScore)
         return "Left side wins!";
      if(rightScore > leftScore)
         return "Right side wins!";
      return "Let's fight again!";
  }
}