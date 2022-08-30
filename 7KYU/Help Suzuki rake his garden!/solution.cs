using System.Linq;
public class Kata
{
    public static string RakeGarden(string garden)
        => string.Join(" ", garden.Split(" ").Select(i => i == "gravel" || i == "rock" ? i : "gravel"));
}