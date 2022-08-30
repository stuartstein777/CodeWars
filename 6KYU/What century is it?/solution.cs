public class Kata
{
  public static string WhatCentury(string year)
  {
      var y = int.Parse(year);
      var century = 0;
      if(y % 100 == 0)
        century = y / 100;
      else
        century = (y / 100) + 1;
    
      return $"{century}{century.OrdinalSuffix()}";
  }
}

public static class CodeWarExtensions
{
    public static string OrdinalSuffix(this int n)
    {
        var j = n % 10;
        var k = n % 100;
        return j switch
        {
            1 when k != 11 => "st",
            2 when k != 12 => "nd",
            3 when k != 13 => "rd",
            _ => "th"
        };
    }
}