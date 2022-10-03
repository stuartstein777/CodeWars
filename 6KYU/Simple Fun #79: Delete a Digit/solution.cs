namespace myjinxin
{
    using System;
    using System.Collections.Generic;  
    using System.Linq;
    
    public class Kata
    {
        public int DeleteDigit(int n)
        {
           var digits = CodeWarsUtilities.NumberToDigits(n).ToList();
           int max = -1;
           var cnt = digits.Count - 1;
           for (int i = 0; i < digits.Count; i++)
           {
               var x = digits.Take(i).Concat(digits.Skip(i+1));
               var nx = CodeWarsUtilities.DigitsToNumber(x);
               if (nx > max)
                  max = nx;
           }
           return max;
        }        
    }
    public static class CodeWarsUtilities
    {
       public static int DigitsToNumber(IEnumerable<int> xs) 
          => int.Parse(string.Join("", xs));
    
       public static IEnumerable<int> NumberToDigits(int n)
       {
           var digits = new List<int>();
           while (n != 0)
           {
               digits.Insert(0, n % 10);
               n /= 10;
           }
           return digits;
       }
    }
}