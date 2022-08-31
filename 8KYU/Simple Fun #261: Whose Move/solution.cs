public class Kata
{
  public static string WhoseMove(string lastPlayer, bool win)
  {
    if(win)
      return lastPlayer;
    else
      return lastPlayer == "white" ? "black" : "white";
  }
}