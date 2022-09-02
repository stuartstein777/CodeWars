using System;

public static class AgeDiff 
{
  public static string CalculateAge(int birth, int yearTo) 
  {
      var age = (yearTo - birth);
      if(age == 1)
        return "You are 1 year old.";
      else if (age == 0)
        return "You were born this very year!";
      else if (age < -1)
        return $"You will be born in {-age} years.";
      else if (age == -1)
        return $"You will be born in 1 year.";
      else
        return $"You are {age} years old.";
  }
}