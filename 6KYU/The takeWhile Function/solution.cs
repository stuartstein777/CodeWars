using System;
using System.Collections.Generic;
public class Kata
{
  public static int[] TakeWhile(int[] arr, Func<int,bool> pred)
  {
    var res = new List<int>();
    for(var i = 0; i < arr.Length; i++)
    {
        if(!pred(arr[i]))
          break;
        res.Add(arr[i]);
    }
    return res.ToArray();
    
  }
}