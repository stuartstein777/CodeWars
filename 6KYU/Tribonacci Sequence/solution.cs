using System.Collections.Generic;
using System.Linq;
public class Xbonacci
{
  public double[] Tribonacci(double[] signature, int n)
  {
      var res = new List<double> {signature[0], signature[1], signature[2]};
      int a = 0, b = 1, c = 2;
      for(int i = 0; i < n-signature.Length; i++)
      {
          res.Add(res[a] + res[b] + res[c]);
          a++; b++; c++;
      }
      return res.Take(n).ToArray();
  }
}