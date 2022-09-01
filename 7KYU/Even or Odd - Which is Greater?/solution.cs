using System.Linq;
public class EvenOrOddKata
{
  public static string EvenOrOdd(string str)
  {
    var digits = str.ToCharArray().Select(c => int.Parse(c.ToString()));
    var oddSum = digits.Where(d => d % 2 != 0).Sum();
    var evenSum = digits.Where(d => d % 2 == 0).Sum();
    if(evenSum > oddSum)
      return "Even is greater than Odd";
    else if(evenSum < oddSum)
      return "Odd is greater than Even";
    else  
      return "Even and Odd are the same";
  }
}