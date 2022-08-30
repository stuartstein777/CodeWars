using System;

public static class Kata
{
    public static int HowManyYears(string date1, string date2)
    {
        var year1  = int.Parse(date1.Substring(0, 4));
        var year2  = int.Parse(date2.Substring(0, 4));
        return (year1 > year2)
          ? year1 - year2
          : year2 - year1;
    }
}