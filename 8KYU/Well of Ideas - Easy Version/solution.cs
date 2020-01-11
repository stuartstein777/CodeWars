using System.Linq;
public class Kata
{
	public static string Well(string[] x)
	{
		var goodCount = x.Where(o => o == "good").Count();
		if(goodCount > 2)
		  return "I smell a series!";
		else if(goodCount > 0 && goodCount <= 2)
		  return "Publish!";
		else
		  return "Fail!";
	}
}