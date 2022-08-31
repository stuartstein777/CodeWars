using System.Collections.Generic;
public class Kata
{
  public static double[] Multiples(int m, double n)
  {
    var multiples = new List<double>();
    
    for(int i = 1; i <= m; i++)
      multiples.Add(n*i);
    
    return multiples.ToArray();
  }
}