namespace Solution 
{
	using System;
	public static class SpacesRemover
	{
		public static string NoSpace(string input)
			=> string.Join("", input.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
	}
}