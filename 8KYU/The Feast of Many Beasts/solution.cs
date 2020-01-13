public class Kata
{
	public static bool Feast(string beast, string dish)
		=> dish.ToLower().StartsWith(beast.Substring(0, 1).ToLower()) &&
		   dish.ToLower().EndsWith(beast.Substring(beast.Length-1).ToLower());
}