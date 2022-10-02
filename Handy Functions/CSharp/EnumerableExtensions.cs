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
    
    public static IEnumerable<IEnumerable<T>> PartitionBy<T>(this IEnumerable<T> xs, Func<T, bool> f)
    {
        var result = new List<IEnumerable<T>>();
        var cnt = xs.Count();
        var last = f(xs.First());
        var partition = new List<T>();
        partition.Add(xs.First());

        for (var i = 1; i < xs.Count(); i++)
        {
            var x = xs.ElementAt(i);
            var fx = f(x);
            if (f(x) == last)
                partition.Add(x);
            else
            {
                result.Add(partition);
                partition = new List<T> { x };
                last = fx;
            }
        }
        result.Add(partition);
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
