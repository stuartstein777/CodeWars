using System.Linq;
public class Kata {
  public static double Billboard(string name, double price = 30)
    => name.Aggregate(0.0, (acc, _) => acc + price);
}
