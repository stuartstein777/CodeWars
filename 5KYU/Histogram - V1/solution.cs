using System.Linq;
public class Dinglemouse 
{
  private static string Summary = "-----------\n1 2 3 4 5 6\n";
  public static string Histogram(int[] results) 
  {
     var max = results.Max();
     var result = string.Empty;
     if(max == 0)
       return Summary;

     for (var i = max; i >= 0; i--)
     {
        for(var d = 0; d < 6; d++)
           result += $"{GetRowEntry(i, d, results)}";
         result = result.TrimEnd() + "\n";
     }
     return result += Summary;
  }  
  
  private static string GetRowEntry(int row, int die, int[] rolls)
  {
      if (rolls[die] == row && rolls[die] != 0)
         return $"{row,-2}";
      return rolls[die] > row ? "# " : "  ";
  }
}