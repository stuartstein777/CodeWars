using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{
  public static int[] ArrayLeaders(int[] numbers)
  {
    var result = new List<int>();
    for(int i = 0; i < numbers.Length; i++)
    {
      if(numbers[i] > numbers.Skip(i+1).Sum())
        result.Add(numbers[i]);
    }
    return result.ToArray();
  }
}