Copy to clipboardusing System;
using System.Linq;
using System.Collections.Generic;
public static class Kata
{
  public static string Remove(string s)
  {
    var words = s.Split(" ");
    var res = new List<string>();

    foreach(var word in words)
    {
        if (word.Count(c => c == '!') != 1)
          res.Add(word);
    }
    
    return string.Join(" ", res);
  }
}