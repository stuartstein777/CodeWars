using System;
using System.Linq;
public static class Kata
{
  static int FindNumber(string s)
    => Convert.ToInt32(s.ToCharArray()
              .First(f => char.IsDigit(f)).ToString());
        
  public static string Order(string words)
    => string.IsNullOrEmpty(words) 
          ? ""
          : string.Join(" ", words.Split(' ')
                                   .Select(i => (FindNumber(i), i))
                                  .OrderBy(c => c.Item1)
                                  .Select(c => c.Item2)
                                  .ToArray());