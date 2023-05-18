namespace myjinxin
{
    using System;
    using System.Linq;
  
    public class Kata
    {
        public int SegmentCover(int[] arr, int len)
        {
            var count = 1;
            var points = arr.OrderBy(a => a).ToArray();
            var last = points[0];
          
            for(var i = 1; i < arr.Length; i++)
            {
                if (points[i] - last > len)
                {
                    count++;
                    last = points[i];
                }
            }

            return count;
       }
    }
}