using System;
public static class Kata
{
    public static double Chain(double input, Func<double,double>[] fs)
    {
        for(var i = 0; i < fs.Length; i++)
            input = fs[i](input);
        return input;
    }
}