using System.Linq;
public class Kata
{
  /// <summary>
  /// Returns the Stanton Measure of the array</summary>
  /// <param name="arr">Int32[] to be evaluated.</param>
  public static int StantonMeasure(int[] arr)
  {
     var ones = arr.Where(x => x == 1).Count();
     return arr.Where(x => x == ones).Count();
  }
}