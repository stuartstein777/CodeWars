using System;
using System.Linq;
using System.Collections.Generic;
public class Kata
{
  public static Counter GetCount(object word)
  {
     if(word is not string)
       return new Counter(0, 0);
    
     var s = (string)word;
     var vowelCnt = 0;
     var consonantCnt = 0;
     var vowels = new HashSet<char>{'a', 'e', 'i', 'o', 'u'};
    
     foreach(var c in s.ToLower())
     {
         if(vowels.Contains(c))
           vowelCnt++;
         else if(char.IsLetter(c))
           consonantCnt++;
     }
     return new Counter(vowelCnt, consonantCnt);
  }
}
