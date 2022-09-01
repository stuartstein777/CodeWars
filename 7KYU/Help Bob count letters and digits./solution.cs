using System;
using System.Linq;
public static class Kata
{
    public static int CountLettersAndDigits(string input)
        => input.ToCharArray()
                .Where(c => char.IsDigit(c) || char.IsLetter(c))
                .Count();
}