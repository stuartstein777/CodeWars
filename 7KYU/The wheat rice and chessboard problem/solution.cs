using System;
class Kata
{
    public static int SquaresNeeded(long grains)
    {
        int count = 0;
        
        while(grains > 0)
        {
			grains /= 2;
			count++;
        }
        return count;
    }
}