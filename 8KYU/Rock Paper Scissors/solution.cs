using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
  private static Dictionary<string, string> Beats = new Dictionary<string, string>
    {
       {"rock", "scissors"},
       {"scissors", "paper"},
       {"paper", "rock"}
    };

  public string Rps(string p1, string p2)
  {
      if(p2 == Beats[p1])
         return "Player 1 won!";
    
      if(p1 == Beats[p2])
         return "Player 2 won!";
         
      return "Draw!";
  }
}