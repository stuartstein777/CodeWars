using System.Collections.Generic;
using System.Linq;
public class Kata
{
	public static List<int> ReverseList(IEnumerable<int> list)
		=> list.Reverse().ToList();
}