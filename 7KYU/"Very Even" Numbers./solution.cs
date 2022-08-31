using System.Linq;
using System;
public class Kata
{
    public static bool IsVeryEvenNumber(int number)
    {
      if(number < 10)
        return number % 2 == 0;
      return IsVeryEvenNumber(number.ToString().Select(d => (int) Char.GetNumericValue(d)).Sum());
    }
}