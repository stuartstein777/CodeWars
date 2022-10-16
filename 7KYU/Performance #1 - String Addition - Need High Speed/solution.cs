using System;
using System.Linq;
using System.Text;

public static class Kata
{
  public static string Performance(Func<int> method)
  { 
    var sb = new StringBuilder();
    
    for(var i = 0; i < 150_000; i++)
        sb.Append(method());
    
    return sb.ToString();
  }
}