using System;
public static class Kata
{
	public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
		=> (mpg * fuelLeft) >= distanceToPump;
}