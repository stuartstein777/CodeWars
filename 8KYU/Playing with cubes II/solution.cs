using System;

public class Cube
{
  private int _side;
  
  //This cube needs your help. 
  //Define a constructor which takes one integer and assignes its value to 'Side'
  public Cube() => _side = 0;
  
  public Cube(int s) => _side = (int)Math.Abs(s);
  
  public int GetSide() => _side;
  
  public void SetSide(int s) => _side = (int)Math.Abs(s);
}