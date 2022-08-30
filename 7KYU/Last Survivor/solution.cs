using System; 
using System.Linq;

public static class Kata
{
    public static string LastSurvivor(string letters, int[] coords)
    {
        for(var i = 0; i < coords.Length; i++)
        {
            var coord = coords[i];
            letters = letters.Substring(0, coord) + letters.Substring(coord+1);
        }
      
        return letters;
    }
}