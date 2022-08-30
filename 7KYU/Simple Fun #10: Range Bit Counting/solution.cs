using System.Linq;
namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int RangeBitCount(int a,int b)
          => Enumerable.Range(a, (b-a)+1)
                       .Select(c => Convert.ToString(c, 2)
                                           .Replace("0", "")
                                           .Length)
                       .Sum();
    }
}