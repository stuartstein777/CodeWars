using System;
public class JosephusSurvivor 
{
  	public static int JosSurvivor(int n, int k) 
    {
    	  var r = 0;
        var i = 1;
      
        while(i != n+1)
        {
          r = (r + k) % i;
          i++;
        }
      
        return r+1;
    }  
}