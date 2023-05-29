using System;
using System.Collections.Generic;
using System.Linq;

public class Remover
{
  public static List<int> RemoveSmallest(List<int> numbers)
  {
    if(!numbers.Any()) return new List<int>();
    var min = numbers[0];
    var minIdx = 0;
    var len = numbers.Count();
    for(var i = 1; i < len; i++)
    {
      if(numbers[i] < min)
      {
        min = numbers[i];
        minIdx = i;
      }
    }
    
    return numbers.Take(minIdx).Concat(numbers.Skip(minIdx+1)).ToList();
  }
}