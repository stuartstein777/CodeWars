using System.Collections.Generic;

public class Kata
{
  public static Dictionary<char, int> CharFreq(string message)
  {
    Dictionary<char, int> frequencies = new Dictionary<char, int>();
    	
    foreach(var s in message)
    {		
		    if (frequencies.ContainsKey(s))
			    frequencies[s]++;
		    else
			    frequencies.Add(s, 1);
    }
	  return frequencies;
  }
}