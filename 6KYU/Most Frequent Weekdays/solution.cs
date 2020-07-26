using System;
using System.Linq;
public class Kata
{
  public static string[] MostFrequentDays(int year)
  {
    // if its a leap year, most common days will be the 1st day of the year and the day after.
    // otherwise return the first day of the year
    var dt = new DateTime(year, 1, 1);
    return ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
      ?  (dt.DayOfWeek == DayOfWeek.Sunday)
        ? new string[] {dt.AddDays(1).DayOfWeek.ToString(), dt.DayOfWeek.ToString()}
        : new string[] {dt.DayOfWeek.ToString(), dt.AddDays(1).DayOfWeek.ToString()}
      : new string[] {dt.DayOfWeek.ToString()};
  }
}