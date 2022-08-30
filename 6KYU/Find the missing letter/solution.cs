using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
    public static char FindMissingLetter(char[] array)
    {
        const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";        
        var firstChar = char.ToUpper(array[0]);
        var startIdx = alphabet.IndexOf(firstChar);
        var missing = alphabet.ToCharArray()
                              .Skip(startIdx)
                              .Take(array.Length + 1)
                              .ToHashSet()
                              .Except(array.Select(char.ToUpper).ToHashSet())
                              .First();
        return char.IsUpper(array[0]) ? missing : char.ToLower(missing);
    }
}
