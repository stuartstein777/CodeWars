namespace CustomAccessors 
{
  using System;
  
  public class NumericAccessor
  {
    private int _number;

    public int Number
    {
        get => _number /2;
        set
        {
            if(value % 2 != 0)
              throw new ArgumentException("not divisible by 2");
            _number = value;
        }
    }
  }
}