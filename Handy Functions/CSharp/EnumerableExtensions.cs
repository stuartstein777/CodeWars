namespace CodeWars;

public static class Extensions
{
    public static IEnumerable<IEnumerable<T>> Partition<T>(this IEnumerable<T> xs, int partitionSize)
    {
        var result = new List<IEnumerable<T>>();
        var cnt = xs.Count();
        for (var i = 0; i < xs.Count(); i += partitionSize)
        {
            var toTake = i + partitionSize > cnt ? (cnt - i) : partitionSize;
            result.Add(xs.Skip(i).Take(toTake));
        }
        return result;
    }  
    
    public static Dictionary<T, int> Frequencies<T>(this IEnumerable<T> xs) where T : notnull
    {
        var res = new Dictionary<T, int>();
        foreach (var x in xs)
        {
            if (res.ContainsKey(x))
                res[x]++;
            else
                res.Add(x, 1);
        }
        return res;
    }
}
