using System;
using System.Linq;
namespace Solution
{
  public static class Program
  {
    public static int[] reverseList(int[] list)
       => Enumerable.Reverse(list).ToArray();
  }
}