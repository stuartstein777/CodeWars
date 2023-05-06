using System;
using System.Numerics;

public class SumFct
{
  public static BigInteger perimeter(BigInteger n) 
  {
    BigInteger total = 0;
    BigInteger a = 4;
    BigInteger b = 4;
    
    for(BigInteger i = 0; i <= n; i++)
    {
      total += a;
      BigInteger c = a + b;
      a = b;
      b = c;
    }
    return total;
  }
}