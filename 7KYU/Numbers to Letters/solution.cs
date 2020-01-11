using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
    public static string Switcher(string[] x)
	{
		var lettersMap = new Dictionary<string, string>
							 {
								 {"29", " "}, {"28", "?"}, {"27", "!"}, {"26", "a"}, {"25", "b"}, {"24", "c"}, {"23", "d"}, {"22", "e"}, {"21", "f"}, {"20", "g"}, {"19", "h"},
								 {"18", "i"}, {"17", "j"}, {"16", "k"}, {"15", "l"}, {"14", "m"}, {"13", "n"}, {"12", "o"}, {"11", "p"}, {"10", "q"}, {"9", "r"}, {"8", "s"},
								 {"7", "t"}, {"6", "u"}, {"5", "v"}, {"4", "w"}, {"3", "x"}, {"2", "y"}, {"1", "z"}
							 };
		return x.Aggregate(string.Empty, (current, l) => current + lettersMap[l.ToLower()]);
	}
}