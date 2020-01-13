using System.Linq;
public static class StringExtensions
{
	public static bool IsUpperCase(this string text)
		=> text.ToCharArray().Where(c => char.IsLetter(c)).All(a => char.IsUpper(a));
}