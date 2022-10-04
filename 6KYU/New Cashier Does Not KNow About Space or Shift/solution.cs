using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
  private static readonly Dictionary<string, int> Menu = new()
  {
      {"Burger", 1},
      {"Fries", 2},
      {"Chicken", 3},
      {"Pizza", 4},
      {"Sandwich", 5},
      {"Onionrings", 6},
      {"Milkshake", 7},
      {"Coke", 8}
  };
  
  public static string GetOrder(string input)
  {	
  	  var orders = new List<MenuItem>();
      foreach (var (menuItem, idx) in Menu)
      {
         var numOrders = Regex.Matches(input, menuItem, RegexOptions.IgnoreCase).Count;
         orders.AddRange(Enumerable.Repeat(new MenuItem(idx, menuItem), numOrders));
      }
        
      return string.Join(" ", orders.OrderBy(c => c.Index)
                                    .Select(c => c.Item));
  }
}

public class MenuItem
{
    public int Index { get; }
    public string Item { get; }

    public MenuItem(int index, string item)
    {
        Index = index;
        Item = item;
    }
}