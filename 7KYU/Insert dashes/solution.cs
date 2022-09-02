using System.Linq;
public class Kata
{
  public static string InsertDash(int num)
  {
    var oddNumbers = "13579";
    var s = num.ToString();
    return string.Join("", s.ToCharArray()
                            .Select((c, i) => {
                              if(i < s.Count()-1 && 
                                 oddNumbers.Contains(s[i]) &&
                                 oddNumbers.Contains(s[i+1]))
                                 return $"{c}-";
                              else
                                return $"{c}";
                            }));
  }
}