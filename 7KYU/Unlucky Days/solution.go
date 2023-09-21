package kata

import "time"

func UnluckyDays(year int) int {
	  date := time.Date(year, time.January, 1, 0, 0, 0, 0, time.UTC)
    unlucky := 0
  
    for {
       if  date.Year() != year {
         break
       }
      
       if date.Day() == 13 && date.Weekday() == time.Friday {
         unlucky +=1
       }
       date = date.Add(time.Hour * 24)
    }
  
    return unlucky
}