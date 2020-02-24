using System;
using System.Linq;
public class Kata
{
  public static int NextId(int[] ids)
  {
    var max = ids.Max()+1;
	  var unused = Enumerable.Range(0, max).Except(ids).OrderBy(c => c);
	  return unused.Any()
			      ? unused.First()
			      : max++;
  }
}