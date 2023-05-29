public class Kata
{
  public static string MyFirstInterpreter(string code)
  {
     var res = "";
     var memory = 0;
     foreach(var c in code)
     {
        if(c == '+')
        {
          memory ++;
          if(memory == 256)
            memory = 0;
        }
        else if (c == '.')
        {
           res += ((char)memory).ToString();
        }  
     }
    
     return res;
  }
}