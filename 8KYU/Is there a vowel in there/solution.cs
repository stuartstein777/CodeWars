using System.Linq;
public class Kata
{
	public static object[] IsVow(object[] a)
	{
		var result = new object[a.Length];

		for (var i = 0; i < a.Length; i++)
		{
			if (int.TryParse(a[i].ToString(), out var n))
			{
				if (n == 97 || n == 101 || n == 105 || n == 111 || n == 117)
					result[i] = ((char) n).ToString();
				else
					result[i] = a[i];
			}
			else
				result[i] = a[i];
		}
		return result;
	}
}