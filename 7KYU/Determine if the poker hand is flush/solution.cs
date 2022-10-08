using System;
using System.Linq;

public class Kata
{
  public static bool CheckIfFlush(string[] cards)
    => cards.Select(c => c[^1..]).Distinct().Count() == 1;
}