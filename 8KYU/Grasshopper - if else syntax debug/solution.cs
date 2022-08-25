public class Player
{
  private int health = 100;
  public int Health
  {
    get
    {
      return this.health;
    }
    set
    {
      health = value;
    }
  }
  
  public Player()
  {
    
  }
  
  //FIXME: This method won't compile for some reason! :(
  public bool CheckAlive()
    => Health > 0;
}