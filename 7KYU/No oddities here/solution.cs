using System.Linq;
public class NoOddities
{
    public static int[] NoOdds(int[] values) 
         => values.Where(v => v % 2 == 0).ToArray();
}