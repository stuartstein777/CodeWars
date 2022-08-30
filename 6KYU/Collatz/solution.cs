using System.Collections.Generic;

public class Kata
{
  public static string Collatz(int n)
  {
      List<int> elements = new();
      while(n > 1)
      {
         elements.Add(n);
         if (n %2 == 0)
             n /= 2;    
         else
             n = (3*n) +1;
      } 
      elements.Add(1);
      return string.Join("->", elements);
  }
}