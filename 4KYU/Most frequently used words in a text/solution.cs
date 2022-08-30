using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class TopWords
{
   private static HashSet<char> ValidWordChars = new HashSet<char>
   {
       'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K',
       'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
       'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
       'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
       'w', 'x', 'y', 'z', '\''
    };
    public static List<string> Top3(string s)
    {
        var frequencies = new Dictionary<string, int>();
        var inWord = true;
        var currentWord = "";
        for (var i = 0; i < s.Length; i++)
        {
             if (ValidWordChars.Contains(s[i])) // it's a valid word char, so add it to current word.
             {
                  currentWord += s[i];
                  inWord = true;
             }
             else
             {
                  if (inWord && currentWord != "")
                  {
                       if (currentWord.Replace("'", "").Length == 0)
                       {
                           currentWord = "";
                           inWord = false;
                       }
                       else
                       {
                           if (frequencies.ContainsKey(currentWord.ToLower()))
                               frequencies[currentWord.ToLower()]++;
                           else
                               frequencies.Add(currentWord.ToLower(), 1);

                           currentWord = "";
                           inWord = false;
                      }
                 }
            }
         }
         if (currentWord != "" && currentWord.Replace("'", "").Length > 0)
         {
             if (frequencies.ContainsKey(currentWord.ToLower()))
                 frequencies[currentWord.ToLower()]++;
             else
                 frequencies.Add(currentWord.ToLower(), 1);
         }
         var result = frequencies.OrderByDescending(kv => kv.Value).Take(3).Select(kv => kv.Key).ToList();
         System.Console.WriteLine(string.Join(",", result));
         return result;
    }
}