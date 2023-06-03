public static class CarInformation
{
  public static int GetNumberOfGears (this Car car)
    => car?.Engine?.GearBox?.NumberOfGears ?? -1;
}