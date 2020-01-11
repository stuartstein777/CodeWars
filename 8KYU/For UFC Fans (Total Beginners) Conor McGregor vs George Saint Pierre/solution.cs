using System;
public static class Kata
{
	public static string Quote(string fighter)
		=> (fighter.ToLower() == "Conor McGregor".ToLower()) 
			? "I'd like to take this chance to apologize.. To absolutely NOBODY!"
			: "I am not impressed by your performance.";
}