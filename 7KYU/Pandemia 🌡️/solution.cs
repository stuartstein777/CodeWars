using System;
using System.Linq;

public class Kata 
{
  public static double infected(string s)
  {
    if(!s.Any(d => d == '1' || d == '0'))
      return 0;
      
    double total = s.Where(c => c != 'X').Count();
    double infected = s.Split('X')
                       .Aggregate(0, (acc, c) => acc += (c.Any(d => d == '1')) ? c.Length : 0);
          
    return infected / total * 100;
  }
}