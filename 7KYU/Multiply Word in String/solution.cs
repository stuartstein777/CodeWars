using System.Collections.Generic;
using System.Linq;
public class Kata
{
    public static string ModifyMultiply(string str,int loc,int num)
      => string.Join("-", Enumerable.Repeat(str.Split(" ")[loc], num));
}