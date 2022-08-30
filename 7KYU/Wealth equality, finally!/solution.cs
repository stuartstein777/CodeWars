using System.Linq;
public class Kata {
  public static void RedistributeWealth(double[] wealth) {
    var toRedistribute = wealth.Aggregate((acc, i) => acc + i);
    var wealthPerPerson = toRedistribute / wealth.Length;
    for(var i = 0; i < wealth.Length; i++)
       wealth[i] = wealthPerPerson;
  }
}