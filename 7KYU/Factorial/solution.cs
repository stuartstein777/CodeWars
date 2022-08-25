using System;

namespace Solution
{
  public static class Program
  {
    public static int factorial(int n)
    {
      var res = 1;
      for(var i = 1; i <= n; i++)
        res *=i;
      return res;
    }
  }
}