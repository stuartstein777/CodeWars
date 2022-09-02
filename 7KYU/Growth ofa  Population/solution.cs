using System;

class Arge {
    
    public static int NbYear(int p0, double percent, int aug, int p)
    {
        int years = 0;
        while(p0 < p)
        {
            p0 = (int)Math.Floor(p0 + aug + (p0 * percent  / 100));
            years++;
        }
        
        return years;
    }
}