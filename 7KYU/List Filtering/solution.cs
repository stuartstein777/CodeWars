using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class ListFilterer
{
	public static IEnumerable<int> GetIntegersFromList(List<object> objects)
		=> objects.OfType<int>().Select(o => int.Parse(o.ToString())).ToList();
}