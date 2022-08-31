using System;
using System.Numerics;
using System.Collections.Generic;
public class Kata
{
  public static BigInteger[] PowersOfTwo(int n)
  {
    Console.WriteLine(n);
    var result = new List<BigInteger>();
    
    for(int i = 0; i <= n; i++)
    {
      result.Add(BigInteger.Pow(2, i));
    }
    
    return result.ToArray();
  }
}