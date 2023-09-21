using System;

public class Kata
{
  public static int UnluckyDays(int year)
  {
    DateTime date = new DateTime(year, 1, 1);
    int unluckyDays = 0;
    while(date.Year == year)
    {
        if(date.DayOfWeek == DayOfWeek.Friday && date.Day == 13)
          unluckyDays ++;
        date = date.AddDays(1);
    }
    return unluckyDays;
  }
}