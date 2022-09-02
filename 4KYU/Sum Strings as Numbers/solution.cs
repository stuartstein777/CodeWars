using System;
using System.Numerics;
public static class Kata
{
    public static string sumStrings(string a, string b)
    {
      var gotA = false;
      var gotB = false;
      BigInteger m, n;
      
      if(a.Length != 0)
      {
        m = BigInteger.Parse(a);
        gotA = true; 
      }
      if(b.Length != 0)
      {
         n = BigInteger.Parse(b);
         gotB = true;
      }
       
      if(gotA && gotB)
        return ((m + n).ToString());
      else if(gotA)
        return m.ToString();
      else
        return n.ToString();
    }
}