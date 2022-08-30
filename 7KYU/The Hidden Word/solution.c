using System.Collections.Generic;
using System.Linq;
namespace CodeWars
{
    public class Kata
    {
        private Dictionary<int, char> Key
          = new (){{6,'a'}, {1,'b'}, {7,'d'}, {4,'e'},
                   {3,'i'}, {2,'l'}, {9,'m'}, {8,'n'},
                   {0,'o'}, {5,'t'}};

        public string hidden(int num)
          => string.Join("", num.ToDigits().Select(n => Key[n]));
    }
  
  public static class CodeWarExtensions
  {
    public static IEnumerable<int> ToDigits(this int n)
    {
        var res = new List<int>();
        while (n != 0)
        {
            res.Insert(0, (int)(n % 10));
            n /= 10;
        }

        return res;
    }
  }
}