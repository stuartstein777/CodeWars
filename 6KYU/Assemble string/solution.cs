public class Kata 
{
    public static string Assemble(string[] copies)
    {
        var result = "";
        if (copies.Length == 0 || copies[0].Length == 0)
            return result;        
      
        for (var i = 0; i < copies[0].Length; i++)
        {
            var found = false;
            for (var j = 0; j < copies.Length; j++)
            {
                if (copies[j][i] != '*' && !found)
                {
                    found = true;
                    result += copies[j][i];
                    break;
                }
            }

            if (!found)
                result += "#";
        }
        
        return result;
    }
}