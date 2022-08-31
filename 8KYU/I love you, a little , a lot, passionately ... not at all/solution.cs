using System;

public class Kata
{
  public static string HowMuchILoveYou(int nb_petals)
  {
    var phrases = new[] {"I love you", "a little", "a lot", "passionately", "madly", "not at all"};
  var petal = 0;  
  for(int i = 1; i < nb_petals; i++)
  {
    petal++;
    if(petal == 6)
      petal = 0;
  }
  
  return phrases[petal];
  }
}