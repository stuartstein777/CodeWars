using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

public class Dinglemouse
{
    public class LetterCount
    {
        public char Letter { get; set; }
        public int Count { get; set; }
    }
    
    /*
        Partition each possibility and animal into parts with a count of the letters. e.g. for
        rabbit
        
        possible animal     = [r, 1] - [a, 1] - [b, 2] - [i, 1] - [t, 1]
        remains rrraaabbbit = [r, 3] - [a, 3] - [b, 3] - [i, 1] - [t, 1]
        
        as long as they have the same number of parts and the letter for each partition is the same at
        each location, and the remains count is >= naimal partition count, then its a match.
    
    */
    public static List<LetterCount> PartitionByLetter(string s)
    {
        List<LetterCount> partitions = new();
        var current = new LetterCount { Letter = s[0], Count = 1 };

        for (var i = 1; i < s.Length; i++)
        {
            if (s[i] != current.Letter)
            {
                partitions.Add(current);
                current = new LetterCount { Letter = s[i], Count = 1 };
                
            }
            else
            {
                current.Count++;
            }
        }

        partitions.Add(current);
        return partitions;
    }
    
    public static string GetAnimal(string remains)
    {
        var possibilities = Preloaded.ANIMALS.Where(a => a.StartsWith(remains.Substring(0, 1)));

        foreach (var possibility in possibilities)
        {
            var animalParts = PartitionByLetter(possibility);
            var remainsParts = PartitionByLetter(remains);
           
            var found = true;
            for (var i = 0; i < animalParts.Count; i++)
            {
                if (animalParts[i].Letter != remainsParts[i].Letter || animalParts[i].Count > remainsParts[i].Count)
                {
                    found = false;
                    break;
                }
            }

            if (found && remainsParts.Count == animalParts.Count)
            {
                return possibility;
            }
        }

        return null;
    }
    
    public static string RoadKill(string photo)
    {
        var pattern = "[^=]";

        var remains = Regex.Matches(photo, pattern);

        if(!remains.Any()) return "??";
        
        var result = GetAnimal(string.Join("", remains.Select(m => m.Value)));
        if (result is null)
            result = GetAnimal(string.Join("", string.Join("", remains.Reverse().Select(m => m.Value))));
        return result ?? "??";
    }
}how did sacklers avoid consequences