using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{
  public static string CannonsReady(Dictionary<string, string> gunners)
    => gunners.All(pair => pair.Value == "aye") ? "Fire!" : "Shiver me timbers!";
}