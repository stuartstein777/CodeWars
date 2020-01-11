using System.Linq;
public class Kata
{
	public static string AbbrevName(string name)
		=> string.Join(".", name.Split(' ').Select(s => s.Substring(0, 1))).ToUpper();
}