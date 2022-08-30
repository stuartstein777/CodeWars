using System.Collections.Generic;
using System.Linq;
public static class Kata
{
  // * PRELOADED:
  // public enum Value { Scissors, Paper, Rock, Lizard, Spock }
  // public enum Ordering { LT, EQ, GT }
  
  private readonly static Dictionary<Value, IEnumerable<Value>> Beats = new Dictionary<Value, IEnumerable<Value>>()
    {
        { Value.Rock,     new []{Value.Scissors, Value.Lizard}},
        { Value.Scissors, new []{Value.Paper, Value.Lizard}},
        { Value.Paper,    new []{Value.Rock, Value.Spock}},
        { Value.Lizard,   new []{Value.Paper, Value.Spock}},
        { Value.Spock,    new []{Value.Scissors, Value.Rock}}
    };
  
  public static Ordering Rpsls(Value a, Value b)
  {
    if(Beats[a].Contains(b))
      return Ordering.GT;
    
    if(Beats[b].Contains(a))
      return Ordering.LT;
    
    return Ordering.EQ;
  }
}