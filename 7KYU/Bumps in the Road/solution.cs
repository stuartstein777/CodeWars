using System.Linq;
class Kata
{
    public static string Bump(string c)
    {
        return c.ToCharArray()
                .Aggregate(0, (acc, i) => i == '_' ? acc : acc+1)
                <= 15
          ? "Woohoo!"
          : "Car Dead";
        
    }
}