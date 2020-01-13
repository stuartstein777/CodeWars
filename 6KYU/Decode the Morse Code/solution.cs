using System.Linq;
using System;
class MorseCodeDecoder
{
	public static string Decode(string morseCode)
		=> string.Join(" ", morseCode.TrimStart().TrimEnd().Split("   ").Select(c => String.Concat(c.Split().Select(m => MorseCode.Get(m)))));
}