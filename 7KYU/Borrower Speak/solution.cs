using System.Linq;
public class Kata
{
	public static string Borrow(string s)
		=> string.Concat(s.Where(char.IsLetter)).ToLower();
}