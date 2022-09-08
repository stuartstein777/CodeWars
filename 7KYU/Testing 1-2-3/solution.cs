using System.Collections.Generic;
using System.Linq;
public class LineNumbering 
{
    public static List<string> Number(List<string> lines) 
       => lines.Select((l, idx) => $"{idx+1}: {l}").ToList();
}