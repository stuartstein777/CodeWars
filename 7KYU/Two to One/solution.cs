using System.Text.RegularExpressions;
using System;
using System.Linq;
public class TwoToOne 
{
  
	public static string Longest (string s1, string s2) 
	{
		var s = (s1 + s2).ToLower();
	    var onlyAtoZ = Regex.Replace(s, "[^a-z]", "");
	    var distinct = new String(onlyAtoZ.Distinct().OrderBy(c => c).ToArray());
	    return distinct;
	}
}