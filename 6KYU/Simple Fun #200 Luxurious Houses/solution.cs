namespace myjinxin
{
    using System;
    using System.Linq;  
    using System.Collections.Generic;
    public class Kata
    {
        public int[] LuxuriousHouse(int[] houses)
        {
          var r = houses.AsEnumerable()
                        .Reverse();
            
          var max = r.First();
          var result = r.Skip(1)
                        .Select((c, i) => {     
                            var toAdd = (max - c >= 0) ? (max - c)+1 : 0;
                            if(c > max)
                              max = c;
                            return toAdd;
                         })
                        .Reverse()
                        .ToList();
          result.Add(0);
          return result.ToArray();
        }
    }
}