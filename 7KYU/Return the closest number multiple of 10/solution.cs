using System;

public class Kata
{
    public int ClosestMultiple10(int num)
    {
        var remainder = num % 10;
        return remainder < 5 ? num - remainder : num + (10 - remainder);      
    }
}