using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
      if (input is null || input.Length == 0)
        return new int[0];
      var positiveCount = 0;
      var negativeSum = 0;
      foreach(var n in input)
        if(n > 0)
          positiveCount ++;
        else
          negativeSum += n;
      return new[]{positiveCount, negativeSum};
    }
}