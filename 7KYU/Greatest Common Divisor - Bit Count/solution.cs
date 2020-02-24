using System;
using System.Linq;
public class BinaryGCD 
{
  public static int GcdBinary(int x, int y) 
    => Convert.ToString(GCD(Math.Abs(x), Math.Abs(y)), 2).ToCharArray().Count(c => c == '1');
  
  private static int GCD(int a, int b)
  {
    while (a != 0 && b != 0)
    {
        if (a > b)
            a %= b;
        else
            b %= a;
    }
    return a == 0 ? b : a;
  }
}