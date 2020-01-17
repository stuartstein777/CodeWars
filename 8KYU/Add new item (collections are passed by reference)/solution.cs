using System;
using System.Collections.Generic;
using System.Linq;
public class AddMore
{
    public static List<int> AddExtra(List<int> listOfNumbers)
      => Enumerable.Range(1, listOfNumbers.Count+1).ToList();
}