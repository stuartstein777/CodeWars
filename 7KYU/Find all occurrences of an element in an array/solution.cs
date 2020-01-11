namespace Solution
{
	using System.Collections.Generic;
  
	public class Kata
	{
		public static int[] FindAll(int[] array, int n)
		{
			var indexes = new List<int>();
  
			for(int i = 0; i < array.Length; i++)
				if(array[i] == n)
					indexes.Add(i);	
  
			return indexes.ToArray();
		}
	}
}