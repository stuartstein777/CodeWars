public class Kata
{
  public static string TripleTrouble(string one, string two, string three)
  {
    var answer = "";
    for(var i = 0; i < one.Length; i++)
      answer += $"{one[i]}{two[i]}{three[i]}";
    return answer;
  }
}