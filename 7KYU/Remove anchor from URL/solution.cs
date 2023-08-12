public static class Kata
{
  public static string RemoveUrlAnchor(string url)
  {
      var anchorIdx = url.IndexOf("#");
    
      if(anchorIdx != -1)
        return url.Substring(0, anchorIdx);
      return url;
  }
}