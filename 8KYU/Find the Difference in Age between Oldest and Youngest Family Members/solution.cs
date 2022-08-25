using System.Linq;

public class Kata
{
  public static int[] DifferenceInAges(int[] ages)
     => new []{ages.Min(), ages.Max(), (ages.Max() - ages.Min())};
}