using System;
public class Kata
{
	public static Tuple<int, int> MineLocation(int[,] field)
	{
		var rowLength = Math.Sqrt(field.Length);
		for(var x = 0; x < field.Length / rowLength; x++)
			for(var y = 0; y < rowLength; y++)
				if(field[x,y] == 1)
					return new Tuple<int, int>(x,y);
    
		return new Tuple<int, int>(0, 0);
  }
}