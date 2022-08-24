using System.Linq;
namespace Solution
{
  class Kata
  {
    public static int find_it(int[] seq) 
    {
      return seq.GroupBy(a => a).FirstOrDefault(g => g.Count() % 2 != 0).Key;
    }
       
  }
}