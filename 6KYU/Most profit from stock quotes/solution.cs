using System;

static class Kata
{
    public static int GetMostProfitFromStockQuotes(int[] quotes)
    {
        var profit = 0;
        var largest = 0;
      
        for(var i = quotes.Length-1; i >= 0; i--)
        {
          if(quotes[i] < largest)
            profit += largest - quotes[i];
          else
            largest = quotes[i];
        }
        return profit;
    }
}