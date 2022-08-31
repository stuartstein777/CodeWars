using System.Linq;
class Kata
{
    public static int MinSum(int[] xs)
    {  
      var total = 0;
      var sorted = xs.OrderBy(a => a).ToList();
      for(int i = 0; i < sorted.Count(); i++)
        total += sorted[i] * sorted[sorted.Count()-1-i];
      return total / 2;
    }
}