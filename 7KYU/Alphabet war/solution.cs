using System.Collections.Generic;
using System.Linq;

public class Kata
{
    private static Dictionary<char, int> LeftPowers = new(){{'w', 4},
                                                            {'p', 3},
                                                            {'b', 2},
                                                            {'s', 1}};
   
    private static Dictionary<char, int> RightPowers = new(){{'m', 4},
                                                             {'q', 3},
                                                             {'d', 2},
                                                             {'z', 1}};
    public static string AlphabetWar(string fight)
    {
      var leftScore = fight.Where(c => LeftPowers.ContainsKey(c))
                           .Select(c => LeftPowers[c]).Sum();
      var rightScore = fight.Where(c => RightPowers.ContainsKey(c))
                            .Select(c => RightPowers[c]).Sum();

      if(leftScore > rightScore)
        return "Left side wins!";

      if(rightScore > leftScore)
        return "Right side wins!";

      return "Let's fight again!";
    }
 }