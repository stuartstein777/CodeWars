using System;
using System.Linq;
public class Kata
{
	public static string ToCamelCase(string str)
	{
		var split = str.Split(new char[]{'_','-'});
		return split[0] + string.Concat(split.Skip(1).Select(s => s.Substring(0, 1).ToUpper() + s.Substring(1)));
	}
}