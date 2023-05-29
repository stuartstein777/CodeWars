using System;
public class IPConvert
{
  public static uint ToInt32(string ip)
  {
    var octets = ip.Split(".");
    var b = "";

    foreach(var octet in octets)
    {
      var bn = Convert.ToString(int.Parse(octet), 2).PadLeft(8, '0');
      b += bn;
    }
    var n = Convert.ToInt64(b, 2);
    return (uint)n;
  }
}