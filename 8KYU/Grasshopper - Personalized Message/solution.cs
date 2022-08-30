public class Kata
{
  public static string Greet(string name, string owner)
    => (name == owner)
      ? "Hello boss"
      : "Hello guest";
}