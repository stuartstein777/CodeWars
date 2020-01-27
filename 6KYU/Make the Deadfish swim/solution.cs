public class Deadfish
{
  public static int[] Parse(string data)
  {
    var v = 0;
    var outputs = new List<int>();
  
    foreach(var d in data)
    {
      if(d == 'i')
        v++;
      else if(d == 'd')
        v--;
      else if(d == 's')
        v *= v;
      else if(d == 'o')
        outputs.Add(v);
    }
    
    return outputs.ToArray();
  }
}