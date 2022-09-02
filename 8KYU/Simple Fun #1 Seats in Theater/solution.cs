public class Kata
{
  public static int SeatsInTheater(int nCols, int nRows, int col, int row)
    => ((nCols+1) - col) * (nRows - row);
}