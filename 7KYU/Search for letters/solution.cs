using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string Change(string input)
  {
     var alphabet = new Dictionary<int, char>
       { {0, 'a'}, {1, 'b'}, {2, 'c'}, {3, 'd'}, {4, 'e'}, {5, 'f'}, {6, 'g'}, {7, 'h'}, {8, 'i'}, {9, 'j'},
         {10, 'k'}, {11, 'l'}, {12, 'm'}, {13, 'n'}, {14, 'o'}, {15, 'p'}, {16, 'q'}, {17, 'r'}, {18, 's'},
         {19, 't'}, {20, 'u'}, {21, 'v'}, {22, 'w'}, {23, 'x'}, {24, 'y'}, {25, 'z'}};
    
     var res = "";
     input = input.ToLower();
     for(var i = 0; i < 26; i++)
     {
        var charToCheck = alphabet[i];
        if(input.Contains(charToCheck))
            res+="1";
        else
            res+="0";       
     }
    
     return res;
  }
}