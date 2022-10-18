using System;

public class KataCalculator
{
  public static int SolvedKatasSince(DateTime registrationDate, DateTime currentDate)
  {
      var days = (currentDate - registrationDate).Days;
      var weekDays = 0;
      for(var i = 0; i < days; i++)
      {
         var day = registrationDate.AddDays(i).DayOfWeek;
         if(day != DayOfWeek.Saturday && day != DayOfWeek.Sunday)
            weekDays++;
      }
      return weekDays;
  }
}