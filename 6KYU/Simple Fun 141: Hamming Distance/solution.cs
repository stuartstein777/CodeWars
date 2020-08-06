namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int HammingDistance(int x, int y)
        {
            var z = x ^ y;
            var i = 0;
            while(z != 0)
            {
              var zn = z -1;
              z &= zn;
              i++;
            }
            return i;
        }
    }
}