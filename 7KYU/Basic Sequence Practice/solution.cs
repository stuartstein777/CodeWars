using System.Collections.Generic;
public class SequenceSum
{
  public static int[] SumOfN(int n)
  {
    var result = new List<int>();
    var sum = 0;
    for(var i = 0; i <= System.Math.Abs(n); i++)
    {
       sum+= n < 0 ? -i : i; 
       result.Add(sum);
    }
    return result.ToArray();
  }
}