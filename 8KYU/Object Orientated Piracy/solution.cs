public class Ship
{
  public int Draft;
  public int Crew;
  
  public Ship(int draft, int crew)
  {
    Draft = draft;
    Crew = crew;
  }
  
  public bool IsWorthIt() => Draft - (Crew * 1.5) > 20; 
}