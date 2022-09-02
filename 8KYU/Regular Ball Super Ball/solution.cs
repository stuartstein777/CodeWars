using System;

public class Ball {
  public string ballType { get; set; }
  
  public Ball(string ballType = "")
  {
    if(!string.IsNullOrEmpty(ballType))
      this.ballType = ballType;
    else
      this.ballType = "regular";
  }
}