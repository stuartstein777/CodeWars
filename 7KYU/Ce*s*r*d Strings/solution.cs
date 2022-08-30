public class Kata
{
  public static string Uncensor(string infected, string discovered)
  {
      var disIdx = 0;
      var recovered = "";

      foreach(var c in infected.ToCharArray())
        if (c == '*')
        {
            recovered += discovered[disIdx];
            disIdx++;
        }
        else
            recovered += c;
    
     return recovered;
  }
}