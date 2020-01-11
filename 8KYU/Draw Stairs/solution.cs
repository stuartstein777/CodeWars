public class Kata
{
	public static string DrawStairs(int n)
	{
		var floors = new string[n];
		for (var i = 0; i < n; i++)
		  floors[i] = "I".PadLeft(i + 1, ' ');
		return string.Join("\n", floors);
	}
}
