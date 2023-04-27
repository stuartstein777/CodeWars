using System.Collections.Generic;
using System.Linq;
public class Kata
{
  public static bool ValidParentheses(string str)
  {
    Stack<byte> stack = new Stack<byte>();
    
    for(var i = 0; i < str.Length; i++)
    {
      if(str[i] == '(')
        stack.Push(0);
      else
      {
         if(stack.Any())
           stack.Pop();
         else
          return false;
      }
    }
    return !stack.Any();
  } 
}