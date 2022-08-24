public class DnaStrand 
{
    public static string MakeComplement(string dna)
       => dna.Replace("A", "t")
             .Replace("T", "a")
             .Replace("C", "g")
             .Replace("G", "c")
             .ToUpper();
}