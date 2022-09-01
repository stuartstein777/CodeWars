using System;
using System.Linq;
public class Kata
{
  public string Pattern(int n)
    => (n < 1)
         ? string.Empty
         : string.Join(Environment.NewLine,
                       Enumerable.Range(1, n)
                                 .Select(i => string.Concat(Enumerable.Repeat(i.ToString(), i))));
}