using System;
using System.Linq;
namespace BinaryOperators {
  public class BitCounting
  {
    public static bool SharedBits(int a, int b)
    {
        var z = a & b;
        var r = Convert.ToString(z, 2)
                       .ToCharArray()
                       .Count(i => i == '1');
        return r >= 2;
    }
  }
}