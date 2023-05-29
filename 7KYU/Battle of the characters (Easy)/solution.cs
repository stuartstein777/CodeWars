Copy to clipboardusing System.Linq;

public class Kata
{
  public static string Battle(string x, string y)
  {
      var px = x.ToCharArray().Select(c => (int)c -64).Sum();
      var py = y.ToCharArray().Select(c => (int)c -64).Sum();
    
      if(px > py)
        return x;
      else if(py > px)
        return y;
      return "Tie!";
  }
}
