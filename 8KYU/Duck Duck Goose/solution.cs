public class Kata
{
	public static string DuckDuckGoose(Player[] players, int goose)
	{
		var playerIndex = -1;
		for(int i = 0; i < goose; i++)
		{
			playerIndex++;
			if(playerIndex == players.Length)
				playerIndex = 0;     
		}
		return players[playerIndex].Name; 
	}
}

public class Player 
{
	public string Name {get;set;}
  
	public Player (string name) 
	{
		this.Name = name;
	}
}