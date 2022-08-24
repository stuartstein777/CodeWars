public class Kata
{
    public static int MaxMultiply(int divisor, int bound)
    {
        var max = 0;
        for(var i = 1; i <= bound; i++) {
           if(i % divisor == 0 && i > max)
             max = i;
        }
        return max;
    }
}