using System.Collections.Generic;
using System.Linq;
public class Kata {
  public static string RobberEncode(string sentence) {
    var consonants = new HashSet<char>
                         {
                           'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','z',
                           'B','C','D','F','G','H','J','K','L','M','N','P','Q','R','S','T','V','W','X','Y','Z'
                         };
    return string.Join("", sentence.ToCharArray()
                                        .Select(c => consonants.Contains(c) 
                                            ? char.IsUpper(c)
                                                ? $"{c}O{c}"
                                                : $"{c}o{c}"
                                            : $"{c}"));
  }
}