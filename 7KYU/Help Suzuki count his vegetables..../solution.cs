using System;
using System.Collections.Generic;
using System.Linq;
public class Suzuki
{
    public static List<Tuple<int,string>> CountVegetables(string s)
    {
        var veggies = new HashSet<string>
            { "cabbage", "carrot", "celery", "cucumber", "mushroom", "onion", "pepper", "potato", "tofu", "turnip" };

        return s.Split(" ")
                .Where(i => veggies.Contains(i))
                .Aggregate(new Dictionary<string, int>(), (acc, i) =>
                {
                    if (acc.ContainsKey(i))
                        acc[i]++;
                    else
                        acc[i] = 1;
                    return acc;
                })
                .OrderByDescending(kv => kv.Value)
                .ThenByDescending(kv => kv.Key)
                .Select((kv) => new Tuple<int, string>(kv.Value, kv.Key))
                .ToList();
    }
}