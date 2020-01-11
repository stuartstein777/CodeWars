using System;
using System.Text.RegularExpressions;
public class Kata
{
	public static bool ValidateUsr(string username) 
	{
		var regex = new Regex("^[a-z0-9_]*$");
		return regex.IsMatch(username) &&
			   username.Length >= 4 && 
			   username.Length <= 16;
	}
}