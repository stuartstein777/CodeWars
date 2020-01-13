using System.Collections.Generic;
using System.Linq;
public static class Filter
{
	public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
	{
		var geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
		return birds.Where(b => !geese.Any(g => g == b)); 
	}
}