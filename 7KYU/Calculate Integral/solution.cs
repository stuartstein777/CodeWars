public class LinFunc
{
  public double M { get; set; }
  public double B { get; set; }
  
  public double GetY(double x)
    => M * x + B;
  
  public double CalcIntegral(int f, int t)
    => 0.5 * M * ((t*t) - (f*f)) + B * (t - f);
}