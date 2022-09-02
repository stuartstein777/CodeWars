using StriveObjects;
using System;

public class Strive
{
  public static bool Match(Candidate c, Job j)
  {
    if(j.MaxSalary == null || c.MinSalary == null)
      throw new Exception("argh");
    return (j.MaxSalary >= (c.MinSalary * 0.9));
  }
}