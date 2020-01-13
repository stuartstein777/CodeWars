using System;
public class Kata
{
	public static int HexToDec(string hexString)
		=> (hexString.StartsWith('-')) 
				? - Convert.ToInt32(hexString.Substring(1), 16)
				: Convert.ToInt32(hexString.ToUpper(), 16);
}