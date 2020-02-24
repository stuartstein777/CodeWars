using System;
using System.Linq;
namespace Solution 
{
  public static class FreeUrinals
  {
    public static int GetFreeUrinals(string urinals)
    {
      var u = urinals.ToCharArray();
			if (urinals.Contains("11"))
				return -1;
			for (var ix = 0; ix < u.Length; ix++)
				if (u[ix] == '0' && (ix - 1 < 0 || u[ix - 1] == '0') && (ix + 1 == u.Length || u[ix + 1] == '0'))
					u[ix] = '2';
			return u.Count(c => c == '2');
    }
  }
}