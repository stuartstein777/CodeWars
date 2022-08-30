using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int Number(List<int[]> peopleListInOut)
        => peopleListInOut.Aggregate(0, (acc, io) => acc + (io[0] - io[1]));
}