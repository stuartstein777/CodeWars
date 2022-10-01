using System;

public static class Kata
{
    public static int Sc(string screws)
    {
        var len = screws.Length;
        var last = screws[0];
        var time = 1;
        for(var i = 1; i < len; i++)
        {
           if(screws[i] == last)
              time++;
           else
           {
             last = screws[i];
             time+=6;
           }
        }

        return time + (len-1);
    }
}