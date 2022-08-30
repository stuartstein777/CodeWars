using System;
using System.Linq;

static class Kata
{
   public static string Plant(char seed, int water, int fert, int temp)
   {
      var plant = string.Join("", Enumerable.Repeat(string.Join("", Enumerable.Repeat("-", water))
                          + string.Join("", Enumerable.Repeat(seed, fert)), water));
      return (temp < 20 || temp > 30)
        ? plant.Replace(seed.ToString(), string.Empty) + seed.ToString()
        : plant;
    
    }
}