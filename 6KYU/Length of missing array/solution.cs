using System.Linq;
public class Kata
{
  public static int GetLengthOfMissingArray(object[][] xs)
  {
     if(xs is null || !xs.Any() || xs.Any(x => x is null))
       return 0;

    var counts = xs.Select(x => x.Length).OrderBy(x => x).ToList();  
     var i = counts.FirstOrDefault();
     if(i == 0)
       return 0;
     foreach (var x in counts.Skip(1))
     {
        if (x - i > 1)
           return i + 1;
        i = x;
     }
     return 0;
  }
}