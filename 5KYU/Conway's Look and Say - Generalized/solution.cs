using System;
using System.Collections.Generic;

public static class Kata
{
  public static int[] NumberToDigits(ulong n)
  {
      var digits = new List<int>();
      while (n != 0)
      {
          digits.Insert(0, (int)(n % 10));
          n /= 10;
      }
      return digits.ToArray();
  }

  public static string Partition(int[] xs)
  {
     var n = xs[0];
     var c = 1;
     var result = "";

     for (var i = 1; i < xs.Length; i++)
     {
         var x = xs[i];
         if (x == n)
         {
             c++;
         }
         else
         {
             result += $"{c}{n}";
             n = x;
             c = 1;
         }
     }

     return result + $"{c}{n}";
  }
  
  public static ulong LookSay(ulong number)
  {
      if(number == 0) return 10ul;
    
      var digits = NumberToDigits(number);
      var partitions = Partition(digits);
      return ulong.Parse(partitions);  
  }
}