using System.Linq;

public class kata
{
  public static int maxDiff(int[] lst)
  {
    if(!lst.Any())
      return 0;
    
    var ordered = lst.OrderBy(c => c);
    return ordered.Last() - ordered.First();
  }
}