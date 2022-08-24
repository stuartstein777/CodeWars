using System.Linq;

public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
      var a = string.Join("", numbers.Take(3));
      var b = string.Join("", numbers.Skip(3).Take(3));
      var c = string.Join("", numbers.Skip(6));
      return $"({a}) {b}-{c}";
  }
}