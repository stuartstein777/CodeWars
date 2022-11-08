using System;
public static class Kata
{
  public static bool IsPrime(int n)
  {
     if(n < 2) return false;
    
     for(int i = 2; i <= Math.Sqrt(n); i++)
         if(n % i == 0)
           return false;
    
     return true;
  }
}