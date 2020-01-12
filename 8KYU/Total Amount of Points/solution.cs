using System.Linq;
public static class Kata
{
    public static int TotalPoints(string[] games)
	{
		var results = games.Select(g => GetResult(g.Split(":")));
		var total = 0;
		foreach (var game in results)
		if (game.Item1 == game.Item2)
			total += 1;
		else if (game.Item1 > game.Item2)
			total += 3;
		return total;
	}

	private static (int, int) GetResult(string[] game)
		=> (int.Parse(game[0]), int.Parse(game[1]));
}