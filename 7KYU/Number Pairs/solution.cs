using System;
using System.Collections.Generic;
public class Kata
{
  public static int [] getLargerNumbers(int [] a , int [] b)
  {
    var xs = new List<int>();
    
    for(var i = 0; i < a.Length; i++) {
      if(a[i] > b[i])
        xs.Add(a[i]);
      else
        xs.Add(b[i]);
    }
    return xs.ToArray();
  }
}