using System;
using System.Collections.Generic;
using System.Linq;
public class Kata 
{
  public static int GetNumber(string str) 
  {
    var digits = Digits(str);
  return digits.Select((x, ix) => int.Parse(string.Join("", digits.Skip(ix).Take(5))))
           .Max();
  }
  
  private static List<int> Digits(string str)
    => str.ToCharArray().Select(c => int.Parse(c.ToString())).ToList();
}