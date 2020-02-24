namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int Rectangles(int n, int m)
          => ((m-1) * (n-1) * n * m) / 4;
    }
}