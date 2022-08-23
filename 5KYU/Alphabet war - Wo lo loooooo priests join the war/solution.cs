using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    static Dictionary<char, int> leftScores = new()
    {
        {'w', 4},{'p', 3},{'b', 2},{'s', 1}
    };

    static Dictionary<char, int> rightScores = new()
    {
        {'m', 4},{'q', 3},{'d', 2},{'z', 1}
    };

    static char ConvertLetter(char c) =>
        c switch
        {
            'w' => 'm',
            'm' => 'w',
            'q' => 'p',
            'p' => 'q',
            'b' => 'd',
            'd' => 'b',
            'z' => 's',
            's' => 'z',
             _ => c
        };

     static bool CanConvertLeft(char[] xs, int i, char priest)
     {
         bool AdjacentIsFriendly() =>
             (priest == 't' && "wpbs".Contains(xs[i-1])) || 
             (priest == 'j' && "mqdz".Contains(xs[i-1]));

         bool AdjacentSurroundedByEnemyPriest() =>
             (priest == 'j' && xs[i - 2] == 't') ||
             (priest == 't' && xs[i - 2] == 'j');

         if (i == 0)
            return false;

         if (i == 1 && !AdjacentIsFriendly())
            return true;

         return !AdjacentIsFriendly() && !AdjacentSurroundedByEnemyPriest();
     }

     static bool CanConvertRight(char[] xs, int i, char priest)
     {
         bool AdjacentIsFriendly() =>
            (priest == 't' && "wpbs".Contains(xs[i+1])) || 
            (priest == 'j' && "mqdz".Contains(xs[i+1]));

         bool AdjacentSurroundedByEnemyPriest() =>
            (priest == 'j' && xs[i + 2] == 't') ||
            (priest == 't' && xs[i + 2] == 'j');
    
         if (i == xs.Length-1)
            return false;

         if (i == xs.Length-2 && !AdjacentIsFriendly())
            return true;

         return !AdjacentIsFriendly() && !AdjacentSurroundedByEnemyPriest();
     }

     static string ConvertPriests(string fight)
     {
        var xs = fight.ToCharArray();
        var res = fight.ToCharArray();
        for (var i = 0; i < xs.Length; i++)
        {
            // COnvert left
            if ((xs[i] == 'j' || xs[i] == 't') && i > 0 && CanConvertLeft(xs, i, xs[i]))
               res[i - 1] = ConvertLetter(xs[i - 1]);

            if ((xs[i] == 'j' || xs[i] == 't') && i < xs.Length - 1 && CanConvertRight(xs, i, xs[i]))
               res[i + 1] = ConvertLetter(xs[i + 1]);
        }
    
        return string.Join("", res);
      }
   
      public static string AlphabetWar(string fight)
      {
          fight = ConvertPriests(fight);
        
          var leftScore = 0;
          var rightScore = 0;

          foreach (var x in fight.ToCharArray())
          {
               if (leftScores.ContainsKey(x))
                  leftScore += leftScores[x];
              if (rightScores.ContainsKey(x))
                  rightScore += rightScores[x];
          }
      
          if(leftScore > rightScore)
              return "Left side wins!";
          if(leftScore < rightScore)
              return "Right side wins!";
      
          return "Let's fight again!";
      }
 }
