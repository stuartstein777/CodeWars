using System;
using System.Linq;
public class Kata
{
  public static int FindSmallest(int[] numbers, string toReturn)
  {
    if(toReturn ==  "value")
      return numbers.Min();
    else
    {
       var min = int.MaxValue;
       var minIdx = 0;
      for(var i = 0; i < numbers.Length; i++)
      {
        if(numbers[i] < min)
        {
          min = numbers[i];
          minIdx = i;
        }
      }
      return minIdx;
    }
  }
}