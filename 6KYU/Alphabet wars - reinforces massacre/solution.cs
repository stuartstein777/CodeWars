using System;
using System.Collections.Generic;

public class Kata
{
   private static string Airstrike(string battlefield, string airstrike)
   {
      var battleFieldArray = battlefield.ToCharArray();
      for (var i = 0; i < airstrike.Length; i++)
      {
         if(airstrike[i] != '*')
            continue;
       
         var iMinus = i - 1;
         var iPlus = i + 1;
         if (iMinus >= 0 && iMinus < battleFieldArray.Length)
            battleFieldArray[iMinus] = '_';
         if (iPlus < battleFieldArray.Length)
            battleFieldArray[iPlus] = '_';
         if(i < battleFieldArray.Length)
            battleFieldArray[i] = '_';
      }
      return string.Join("", battleFieldArray);
   }

   private static string Reinforce(string[] reinforcements, Dictionary<int, int> bombed, string battlefield)
   {
       var battleFieldArr = battlefield.ToCharArray();
       for (var i = 0; i < battleFieldArr.Length; i++)
       {
           if (battleFieldArr[i] == '_')
           {
              var reinforcement = bombed[i];
              if(reinforcement < reinforcements.Length)
                  battleFieldArr[i] = reinforcements[reinforcement][i];
           }
       }
       return string.Join("", battleFieldArr);
    }
   
    public static string AlphabetWar(string [] reinforces, string[] airstrikes)
    {
        var bombed = new Dictionary<int, int>();
        var battleField = reinforces[0];
        foreach (var airstrike in airstrikes)
        {
            battleField = Airstrike(battleField, airstrike);
    
            for (var i = 0; i < battleField.Length; i++)
            {
                if (battleField[i] == '_')
                  if (bombed.ContainsKey(i))
                    bombed[i]++;
                  else
                    bombed.Add(i, 1);
            }

            battleField = Reinforce(reinforces, bombed, battleField);
        }
        return battleField;
    }
}
