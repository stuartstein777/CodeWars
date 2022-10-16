using System.Collections.Generic;
using System.Linq;
public class Kata
{
  public static int[] Remove(int[] integerList, int[] valuesList)
  {
     var res = new List<int>();
     var toExclude = valuesList.ToHashSet();
     foreach(var n in integerList)
     {
       if(!toExclude.Contains(n))
       {
          res.Add(n);
       }
     }
     return res.ToArray();
  }
}