using System;
using System.Linq;
public class Kata
{
   public string Pattern(int n)
     => (n < 1)
        ? string.Empty 
	      : string.Join("\n", Enumerable.Range(1, n)
			                 		 				    .Select(c => string.Concat(Enumerable.Range(c, (n - (c-1))).Reverse())));
}