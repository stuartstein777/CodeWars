public class Kata
{
  public static int HammingDistance(string a, string b)
  {
    var h = 0;
    for(var i = 0; i < a.Length; i++)
    {
      if(a[i] != b[i])
        h++;
    }
    return h;
  }
}