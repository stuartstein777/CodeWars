using System;
using System.Linq;
using System.Text;

public static class Kata
{
  public static string Tops(string msg)
  {
    if(string.IsNullOrEmpty(msg)) return "";
    var res = new StringBuilder();
    int n = 1;
    int idx = 1;
    do
    {
        res.Append(msg[idx]);
        n++;
        idx = n * (2 * n - 1);
    } while (idx < msg.Length);

    return string.Join("", res.ToString().Reverse());
  }
}