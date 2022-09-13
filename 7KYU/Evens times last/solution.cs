using System;
namespace EvenTimesLast
{
	public static class Solver
	{
		public static int EvenTimesLast(int[] arr)
		{
        if(arr.Length == 0)
          return 0;
        var total = 0;
			  for(var i = 0; i < arr.Length; i+=2)
        {
           total+=arr[i];
        }
        return total * arr[arr.Length-1];
		}
	}
}