using System;
using System.Linq;
public static class Kata
{
    public static int GetVowelCount(string str)
      => str.Count("aeiouAEIOU".Contains);
}