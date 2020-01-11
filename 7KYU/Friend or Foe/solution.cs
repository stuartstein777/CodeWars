using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{
	public static IEnumerable<string> FriendOrFoe (IEnumerable<string> names)
		=> names.Where(name => name.Length == 4);
}