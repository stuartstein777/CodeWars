public static class Kata 
{
	public static bool IsLockNessMonster(string sentence) 
		=> sentence.ToLower().Contains("tree fiddy") || sentence.ToLower().Contains("3.50");
}