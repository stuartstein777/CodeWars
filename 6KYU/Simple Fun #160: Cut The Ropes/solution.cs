namespace myjinxin
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
  
    public class Kata
    {
        public int[] CutTheRopes(int[] ropes){
           var ropesLeft = ropes.Length;
           var result = new List<int>{ropesLeft};

           while (ropes.Any(r => r > 0))
           {
               var smallestRope = ropes.Where(r => r > 0).Min();
               for (var i = 0; i < ropes.Length; i++)
               {
                   var rope = ropes[i];
                   if (rope > 0)
                   {
                       rope -= smallestRope;
                       if (rope <= 0)
                       {
                           ropesLeft--;
                           rope = 0;
                       }
                        ropes[i] = rope;
                   }
               }
               if(ropesLeft > 0) result.Add(ropesLeft);
           }
           return result.ToArray();
        }
    }
}