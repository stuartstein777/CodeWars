using System;
using System.Linq;
public static class Kata
{
  public static int SumOfDifferences(int[] arr)
  {
     if(arr.Length < 2) return 0;
     var sorted = arr.OrderByDescending(x => x).ToList();
     var answer = 0;
     for(var i = 0; i < sorted.Count()-1; i++)
     {
       answer += (sorted[i] - sorted[i+1]);
     }
     return answer;
  }
}