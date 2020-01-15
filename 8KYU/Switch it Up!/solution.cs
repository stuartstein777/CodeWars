using System.Collections.Generic;
public class Kata
{
	private static Dictionary<int, string> _translations = new Dictionary<int, string>
            {
              {0, "Zero"}, {1, "One"}, {2, "Two"}, {3, "Three"}, {4, "Four"},
              {5, "Five"}, {6, "Six"}, {7, "Seven"}, {8, "Eight"}, {9, "Nine"}
            };
	public static string SwitchItUp(int number)
	{
		return _translations[number];
	}
}