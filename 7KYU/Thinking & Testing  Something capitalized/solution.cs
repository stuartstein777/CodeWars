namespace myjinxin
{
    using System;
    using System.Linq;
    public class Kata
    {
        public string Testit(string s)
        {
			Console.WriteLine(s);
			if(s.Length > 1)
				return string.Join(" ", s.Split(' ')
				                         .Select(w => w.Substring(0, w.Length-1) + char.ToUpper(w[w.Length-1])));
			return s.ToUpper();
        }
    }
}