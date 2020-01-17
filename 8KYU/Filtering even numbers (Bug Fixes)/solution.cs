using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static List<int> FilterOddNumber(List<int> listOfNumbers)
      => listOfNumbers.Where(n => n % 2 != 0).ToList();
}