using System.Collections.Generic;
using System.Linq;
public class Kata
{
    private static readonly Dictionary<char, char> Rotations =
        new()
        {
            { 'a', 'n' }, { 'b', 'o' }, { 'c', 'p' }, { 'd', 'q' }, { 'e', 'r' }, { 'f', 's' }, { 'g', 't' },
            { 'h', 'u' }, { 'i', 'v' }, { 'j', 'w' }, { 'k', 'x' }, { 'l', 'y' }, { 'm', 'z' }, { 'n', 'a' },
            { 'o', 'b' }, { 'p', 'c' }, { 'q', 'd' }, { 'r', 'e' }, { 's', 'f' }, { 't', 'g' }, { 'u', 'h' },
            { 'v', 'i' }, { 'w', 'j' }, { 'x', 'k' }, { 'y', 'l' }, { 'z', 'm' },
            { 'A', 'N' }, { 'B', 'O' }, { 'C', 'P' }, { 'D', 'Q' }, { 'E', 'R' }, { 'F', 'S' }, { 'G', 'T' },
            { 'H', 'U' }, { 'I', 'V' }, { 'J', 'W' }, { 'K', 'X' }, { 'L', 'Y' }, { 'M', 'Z' }, { 'N', 'A' },
            { 'O', 'B' }, { 'P', 'C' }, { 'Q', 'D' }, { 'R', 'E' }, { 'S', 'F' }, { 'T', 'G' }, { 'U', 'H' },
            { 'V', 'I' }, { 'W', 'J' }, { 'X', 'K' }, { 'Y', 'L' }, { 'Z', 'M' }
        };

    private static char Rotate(char c)
        => Rotations.ContainsKey(c) ? Rotations[c] : c;
  
    public static string Rot13(string message)
        => string.Join("", message.ToCharArray()
                                  .Select(Rotate));
}