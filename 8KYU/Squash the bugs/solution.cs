using System;
using System.Linq;

public static class Kata
{
    public static int FindLongest(string str)
      => str.Split(" ").Select(s => s.Length).Max();      
}