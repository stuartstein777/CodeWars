using System.Linq;
public class Kata
{
  public static int FindEvenIndex(int[] arr)
  {
    for(int n = 0; n < arr.Length; n++)
	  {
		   var left = arr.Where((_, i) => i < n).Sum();
		   var right = arr.Where((_, i) => i > n).Sum();
		   if(left == right)
			    return n;
	  }
	  return -1;
  }
}