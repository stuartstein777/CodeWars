using System.Collections.Generic;
using System.Linq;
public class Kata {
  public static object[] Alternate(int n, object firstValue, object secondValue) {
    var xs = new List<object>();
    
    for(var i = 0; i < n; i++)
    {
      xs.Add(firstValue);
      xs.Add(secondValue);
    }
    
    return xs.Take(n).ToArray();
  }
}