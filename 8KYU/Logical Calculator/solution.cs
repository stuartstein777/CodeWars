using System.Linq;
public class Kata
{
	public static bool LogicalCalc(bool[] array, string op)
	{
		var result = array[0];
      
		foreach(var i in array.Skip(1))
		{
			switch(op)
			{
				case "AND":
					result &= i;
					break;
				case "OR":
					result |= i;
					break;
				case "XOR":
					result ^= i;
					break;
			}
		}
		return result;
	}
}

// Second solution
using System.Collections.Generic;
using System.Linq;
using System;
public class Kata
{
	private static Dictionary<string, Func<bool, bool, bool>> _operations = new Dictionary<string, Func<bool, bool, bool>>()
																				{
																					{"AND", (x, y) => x & y},
																					{"OR", (x, y) => x | y},
																					{"XOR", (x, y) => x ^ y}
																				};
	public static bool LogicalCalc(bool[] array, string op)
		=> array.Skip(1).Aggregate(array[0], (current, b) => _operations[op](current, b));
}