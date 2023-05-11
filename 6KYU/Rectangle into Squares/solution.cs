using System.Collections.Generic;
public class SqInRect {
	
	public static List<int> sqInRect(int l, int w) {
		if(l == w) return null;
    var res = new List<int>();
    
    while(l != 0 && w != 0)
    {
      if(l < w) {
        res.Add(l);
        w -= l;
      } else {
        res.Add(w);
        l -= w;
      }
    }
    return res;
	}
}
