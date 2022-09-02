class Kata
{
    public static int[] RowWeights(int[] xs)
    {
        var i = 0;
        var evens = 0;
        var odds = 0;
        
        foreach(var n in xs)
        {
          if(i % 2 == 0)
            evens += n;
          else
            odds += n;
          
          i++;
        }
        
        return new int[2]{evens, odds};
    }
}