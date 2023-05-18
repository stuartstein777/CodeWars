using System.Collections.Generic;
using System.Linq;
namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public string MissingAlphabets(string inp){
          System.Console.WriteLine(inp);
          var alphabet = "abcdefghijklmnopqrstuvwxyz";
          int len = inp.Length;
          Dictionary<char, int> alphabetCounts = new ();

          for(int i = 0; i < len; i++)
          {
            if(alphabetCounts.ContainsKey(inp[i]))
            {
              alphabetCounts[inp[i]] ++;
            }
            else
            {
              alphabetCounts.Add(inp[i], 1);
            }
          }
          var max = alphabetCounts.Values.Max();
          var res = "";
          for(int i = 0; i < 26; i++)
          {
            var a = alphabet[i];
            if(alphabetCounts.ContainsKey(a))
            {
              var occ = alphabetCounts[a];
              res += string.Join("", Enumerable.Repeat(a.ToString(), max-occ));
            }
            else
            {
              res += string.Join("", Enumerable.Repeat(a.ToString(), max));
            }
          }
          return res;
        }
    }
}