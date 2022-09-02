using System.Linq;
using System.Collections.Generic;
class Kata
{
    public static bool TidyNumber(int n)
    {
       var digits = Split(n);
       for(int i = digits.Count()-1; i > 0; i--)
          if(digits[i] > digits[i-1])
             return false;
       return true;
    }

    public static List<int> Split(int n)
    {
       List<int> digits = new List<int>();
  
       while (n != 0)
       {
          digits.Add(n % 10);
          n/= 10;
       }
       return digits;
    }
}