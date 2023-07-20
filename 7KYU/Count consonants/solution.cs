using System;
using System.Collections.Generic;
public class Kata
{
  public static int ConsonantCount(string str)
  {
    var vowels = new HashSet<char>(){'a', 'e', 'i', 'o', 'u'};
    int cnt = 0;
    foreach(var c in str.ToLower())
    {
       if(!vowels.Contains(c) && char.IsLetter(c))
         cnt++;
    }
    return cnt;
  }
}