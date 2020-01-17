using System.Collections.Generic;
using System.Linq;
using System;
public class Fixer
{
  public static List<int> PipeFix(List<int> numbers)
    => Enumerable.Range(numbers.Min(), (numbers.Max()-numbers.Min())+1).ToList();
}