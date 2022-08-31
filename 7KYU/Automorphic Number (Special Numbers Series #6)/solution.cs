class Kata
{
    public static string Automorphic(int n)
      => ((n * n).ToString().EndsWith(n.ToString()))
           ? "Automorphic"
           : "Not!!";
}