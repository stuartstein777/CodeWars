using System;
using System.Linq;
using System.Text.RegularExpressions;
public class Kata
{
  public static int SumOfIntegersInString(string s)
  {
      var matches = Regex.Matches(s, @"\d+");
      var total = 0;
      foreach(Match match in matches)
      {
          GroupCollection groups = match.Groups;
          total += int.Parse(match.Value.ToString());
      }
      return total;  
  }
}