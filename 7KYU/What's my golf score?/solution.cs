using System;
using System.Linq;
public static class Kata
{
  public static int GolfScoreCalculator(string par, string score)
  {
    if(par is null || score is null)
      throw new ArgumentNullException();
    if(par.Length != score.Length)
      throw new ArgumentException();
    if(par.ToCharArray().Any(c => !Char.IsDigit(c)) || score.ToCharArray().Any(c => !Char.IsDigit(c)))
      throw new ArgumentException();
    
    var scores = score.ToCharArray().Select(s => int.Parse(s.ToString()));
    var pars = par.ToCharArray().Select(s => int.Parse(s.ToString())).ToList();
    return scores.Select((x, i) => x - pars[i]).Sum();
  }
}