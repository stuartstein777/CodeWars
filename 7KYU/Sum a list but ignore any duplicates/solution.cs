using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static int SumNoDuplicates(int[] arr)
     => arr.GroupBy(a => a)
           .Where(g => g.Count() == 1)
           .SelectMany(c => c)
            .Sum();    
}